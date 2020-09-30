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
    public partial class DataUser : Form
    {
        Admin admin;
        MainMenu menu;
        bool edit = false;
        int id;
        string nama;

        public DataUser(MainMenu mn)
        {
            InitializeComponent();
            menu = mn;

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("namauser", "Nama User");
            dataGridView1.Columns.Add("jabatan", "Jabatan");

            comboJabatan();
            tampilData();
            bHapus.Visible = false;
        }

        private void tampilData()
        {
            MySqlConnection con = Koneksi.koneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT id, nama_user, jabatan FROM data_user", con);
            MySqlDataReader read = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (read.Read())
            {
                dataGridView1.Rows.Add(new object[] {
                    read["id"].ToString(), read["nama_user"].ToString(), read["jabatan"].ToString()
                });
            }
            con.Close();
        }

        private void tampilData(int id, string nama)
        {
            MySqlConnection con = Koneksi.koneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT nama_user, jabatan, password FROM data_user WHERE id = '" + id +
                "' AND nama_user = BINARY '" + nama + "'", con);
            MySqlDataReader read = cmd.ExecuteReader();

            read.Read();
            tNamaUser.Text = read["nama_user"].ToString();
            cbJabatan.SelectedItem = read["jabatan"].ToString();
            tPassword.Text = read["password"].ToString();
            con.Close();

            edit = true;
        }

        private void comboJabatan()
        {
            cbJabatan.Items.Add("user");
            cbJabatan.Items.Add("admin");
            cbJabatan.SelectedItem = "user";
        }

        private void button4_Click(object sender, EventArgs e) { tampilData(); }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tNamaUser.Text.Equals("") || !tPassword.Text.Equals(""))
            {
                try
                {
                    MySqlConnection con = Koneksi.koneksi();
                    if (!edit)
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO data_user(nama_user, jabatan, password)" +
                            " VALUES(@nama, @jabatan, @password)", con);
                        cmd.Parameters.AddWithValue("@nama", tNamaUser.Text);
                        cmd.Parameters.AddWithValue("@jabatan", cbJabatan.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@password", tPassword.Text);
                        cmd.ExecuteNonQuery();

                        tNamaUser.Text = "";
                        cbJabatan.SelectedItem = "user";
                        tPassword.Text = "";

                        tampilData();
                    }
                    else
                    {
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand("UPDATE data_user SET nama_user = @nama, jabatan = @jabatan, password = @password" +
                            " WHERE id = '" + id + "'", con);
                            cmd.Parameters.AddWithValue("@nama", tNamaUser.Text);
                            cmd.Parameters.AddWithValue("@jabatan", cbJabatan.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@password", tPassword.Text);
                            cmd.ExecuteNonQuery();
                        }
                        catch ( Exception msg)
                        {
                            MessageBox.Show(msg.ToString());
                        }

                        tNamaUser.Text = "";
                        cbJabatan.SelectedItem = "user";
                        tPassword.Text = "";

                        tampilData();

                        id = 0;
                        edit = false;
                        bHapus.Visible = false;
                    }
                    con.Close();
                } catch { }
            }
            else
            {
                MessageBox.Show("Lengkapi Data Anda Terlebih Dahulu!!", "Data Tidak Lengkap", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                if (tNamaUser.Text.Equals(""))
                    tNamaUser.Focus();
                else
                    tPassword.Focus();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                edit = true;
                bHapus.Visible = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                nama = row.Cells[1].Value.ToString();

                tampilData(id, nama);
            }
        }

        private void bHapus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus User Ini?", "Konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))
            {
                MySqlConnection con = Koneksi.koneksi();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM data_user WHERE id = '" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                tNamaUser.Text = "";
                cbJabatan.SelectedItem = "user";
                tPassword.Text = "";

                tampilData();

                id = 0;
                edit = false;
                bHapus.Visible = false;

                if (nama.Equals(Koneksi.Session_Username))
                {
                    MessageBox.Show("User Ini Telah Dihapus, Silahkan Login Kembali!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    Function.Logout(menu);
                }
            }
        }
    }
}
