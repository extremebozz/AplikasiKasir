using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
                return berhasil;
            }
            catch
            {
                MessageBox.Show("Periksa Kembali Database Anda!", "Error", MessageBoxButtons.OK , MessageBoxIcon.Stop);
            }
                
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
