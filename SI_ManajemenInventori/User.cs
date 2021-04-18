using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_ManajemenInventori
{
    public class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static void TambahData(User user)
        {
            string sql = "insert into user(username, password) values('" + user.Username + "', '" + user.Password + "')";
            Koneksi.JalankanPerintahDML(sql);
        }
    }
}
