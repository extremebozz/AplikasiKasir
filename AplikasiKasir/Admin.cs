using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AplikasiKasir.Function;

namespace AplikasiKasir
{
    public partial class Admin : Form
    {
        MainMenu menu;
        Form activeForm;
        CultureInfo idID = CultureInfo.CreateSpecificCulture("id-ID");
        Timer t = null;

        public Admin(MainMenu mn)
        {
            InitializeComponent();
            StartTimer();
            menu = mn;
            lUser.Text = "Selamat Datang, " + Koneksi.Session_Username + "!";
        }
        
        private void StartTimer()
        {
            t = new Timer();
            t.Interval = 500;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e) 
        { 
            lJam.Text = DateTime.Now.ToString("dd MMMM yyyy , ", idID) + DateTime.Now.ToString("HH:mm:ss");
        }            

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            Text = childForm.Text + " ( " + Koneksi.Session_Username + " )";
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pChild.Controls.Add(childForm);
            pChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) { openChildForm(new Kasir(menu)); }        

        private void button2_Click(object sender, EventArgs e) { openChildForm(new DataUser(menu)); }

        private void button3_Click(object sender, EventArgs e) { Logout(menu); }

        private void button4_Click(object sender, EventArgs e) { openChildForm(new DataProduk()); }

        private void button5_Click(object sender, EventArgs e) { openChildForm(new DataPembelian()); }
    }
}
