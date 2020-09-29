using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir
{
    public partial class Login : Form
    {
        //private static Login _instance;
        MainMenu mn;
        
        //public static Login getInstance()
        //{
        //    if (_instance == null) _instance = new Login(mn);
        //    return _instance;
        //}

        public Login(MainMenu mm)
        {
            InitializeComponent();
            mn = mm;
            //Ini edit dari laptop silvina
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tUsername.Text.Equals("") && !tPassword.Text.Equals(""))
            {
                MySqlConnection con = Koneksi.koneksi();
                MySqlCommand cmd = new MySqlCommand("SELECT nama_user, jabatan FROM data_user WHERE nama_user = BINARY '" +
                    tUsername.Text + "'AND password = BINARY '" + tPassword.Text + "'", con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    Koneksi.Session_Username = read["nama_user"].ToString();
                    switch (read["jabatan"])
                    {
                        case "admin":
                            mn.openChildForm(new Admin(mn));
                            break;

                        case "user":
                            mn.openChildForm(new Kasir(mn));
                            break;
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password anda salah!", "Gagal Login");
                    tUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Masukan Username Dan Password Anda!", "Data Tidak Lengkap");
                tUsername.Focus();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult mb = MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            //if (mb.Equals(DialogResult.Yes))
            //    Application.ExitThread();
            //else
            //    e.Cancel = true;
        }

        private void keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
