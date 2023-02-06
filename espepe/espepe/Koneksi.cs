using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace espepe
{
    class Koneksi
    {
        public MySqlConnection getKon()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=spp;username=root;password=;";
            return conn;
        }
    }
}
