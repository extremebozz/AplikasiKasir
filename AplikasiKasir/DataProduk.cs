using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir
{
    public partial class DataProduk : Form
    {
        CultureInfo idID = CultureInfo.CreateSpecificCulture("id-ID");
        bool edit = false;

        public DataProduk()
        {
            InitializeComponent();
            bHapus.Visible = false;

            dataGridView1.Columns.Add("kode", "Kode Barang");
            dataGridView1.Columns.Add("nama", "Nama Barang");
            dataGridView1.Columns.Add("harga", "Harga Barang");

            tampilData();
        }

        private void tampilData()
        {
            MySqlConnection con = Koneksi.koneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_produk", con);
            MySqlDataReader read = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (read.Read())
            {
                dataGridView1.Rows.Add(new object[] {
                    read["kode_produk"].ToString(), read["nama_produk"].ToString(),
                    String.Format(idID, "{0:#,##0}", Convert.ToInt64(read["harga_produk"].ToString()))
                });
            }

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tKodeProduk.Text = row.Cells[0].Value.ToString();
                tNamaProduk.Text = row.Cells[1].Value.ToString();
                tHargaProduk.Text = String.Format(idID, "{0:#,##0}", Convert.ToInt64(Regex.Replace(row.Cells[2].Value.ToString(),
                    @"[\W+\.~]", "")));

                edit = true;
                bHapus.Visible = true;
                tKodeProduk.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Koneksi.koneksi();

            if (!edit)
            {                
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO data_produk(kode_produk, nama_produk, harga_produk)" +
                        " VALUES(@kode, @nama, @harga)", con);
                    cmd.Parameters.AddWithValue("@kode", tKodeProduk.Text);
                    cmd.Parameters.AddWithValue("@nama", tNamaProduk.Text);
                    cmd.Parameters.AddWithValue("@harga", Regex.Replace(tHargaProduk.Text, @"[\W+\.~]", ""));
                    cmd.ExecuteNonQuery();

                    tKodeProduk.Text = "";
                    tNamaProduk.Text = "";
                    tHargaProduk.Text = "";

                    tampilData();
                }
                catch ( Exception msg )
                {
                    MessageBox.Show(msg.ToString());
                }
            }
            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE data_produk SET nama_produk = @nama, harga_produk = @harga WHERE" +
                        " kode_produk = BINARY '" + tKodeProduk.Text + "'", con);
                    cmd.Parameters.AddWithValue("@kode", tKodeProduk.Text);
                    cmd.Parameters.AddWithValue("@nama", tNamaProduk.Text);
                    cmd.Parameters.AddWithValue("@harga", Regex.Replace(tHargaProduk.Text, @"[\W+\.~]", ""));
                    cmd.ExecuteNonQuery();

                    tKodeProduk.Text = "";
                    tNamaProduk.Text = "";
                    tHargaProduk.Text = "";

                    bHapus.Visible = false;
                    tKodeProduk.Enabled = true;

                    tampilData();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                }
            }
            con.Close();
        }

        private void bHapus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr.Equals(DialogResult.Yes))
            {
                MySqlConnection con = Koneksi.koneksi();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM data_produk WHERE kode_produk = BINARY '" + tKodeProduk.Text + "'", con);
                cmd.ExecuteNonQuery();

                tKodeProduk.Text = "";
                tNamaProduk.Text = "";
                tHargaProduk.Text = "";

                tKodeProduk.Enabled = true;
                bHapus.Visible = false;

                tampilData();
                con.Close();
            }
        }
    }
}
