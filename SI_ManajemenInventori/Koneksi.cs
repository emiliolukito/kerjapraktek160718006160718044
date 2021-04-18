using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SI_ManajemenInventori
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        #region Constructor

        public Koneksi()
        {
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ConnectionString;
            Connect();
        }
        public Koneksi(string server, string database, string username, string pwd)
        {
            string strCon = "server=" + server + ";port=3307;database=" + database + ";uid=" + username + ";password=" + pwd + ";charset=utf8";

            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();

            UpdateAppConfig(strCon);
        }
        #endregion

        #region Method
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public void UpdateAppConfig(string connString)
        {
            Configuration myConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            myConfig.ConnectionStrings.ConnectionStrings["koneksiku"].ConnectionString = connString;
            myConfig.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();
            k.Connect();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            c.ExecuteNonQuery();
        }
        #endregion
        
    }
}
