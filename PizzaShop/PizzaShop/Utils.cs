using MySql.Data.MySqlClient;
using System;

namespace PizzaShop
{
    class Utils
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi426146;Database=dbi426146;Pwd=SuperSecurePassword;");
            return conn;
        }

        public static DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
