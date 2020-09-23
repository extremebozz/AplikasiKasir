﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir
{
    public class Koneksi
    {
        public static string Session_Username = String.Empty;

        public static bool cekKoneksi()
        {
            bool berhasil = false;
            try
            {
                var con = new MySqlConnection("Server=localhost;Database=aplikasikasir;Uid=root;Pwd=");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                    berhasil = true;
                con.Close();
            } catch { }
            return berhasil;
        }

        public static MySqlConnection koneksi()
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection("Server=localhost;Database=aplikasikasir;Uid=root;Pwd=");
                con.Open();
            }
            catch { }
            return con;
        }
    }
}
