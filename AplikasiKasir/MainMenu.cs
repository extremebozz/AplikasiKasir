using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AplikasiKasir.Function;

namespace AplikasiKasir
{
    public partial class MainMenu : Form
    {
        private Form activeForm = null;
        public MainMenu()
        {
            InitializeComponent();
            //MaximizeBox = false;
            MinimizeBox = false;
            cekSession();
            this.BringToFront();
        }

        public void cekSession()
        {
            Login lg = new Login(this);
            if (lg.IsDisposed == true)
                lg = new Login(this);
            if (Koneksi.Session_Username.Equals(""))
                openChildForm(lg);
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

        public void openChildForm(Login childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            Text = "Login Page";
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Location = new Point((Screen.GetWorkingArea(this).Width - childForm.Width) / 2, (Screen.GetWorkingArea(this).Height - childForm.Height) / 2);
            //childForm.Dock = DockStyle.Fill;
            childForm.StartPosition = FormStartPosition.CenterParent;
            pChild.Controls.Add(childForm);
            pChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
