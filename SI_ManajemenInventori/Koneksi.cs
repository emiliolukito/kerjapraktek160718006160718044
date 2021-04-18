using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SI_ManajemenInventori
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        #region Constructor
        public Koneksi(string server, string database, string username, string pwd)
        {
            string strCon = "server=" + server + ";port=3307;database=" + database + ";uid=" + username + ";password=" + pwd + ";charset=utf8";

            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();
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
        #endregion
        
    }
}
