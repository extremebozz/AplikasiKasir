using MySql.Data.MySqlClient;
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

namespace AplikasiKasir
{
    public partial class DetailPembelian : Form
    {
        CultureInfo idID = CultureInfo.CreateSpecificCulture("id-ID");
        public DetailPembelian(string invoice, string nama)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lInvoice.Text = "Invoice : " + invoice;
            lKasir.Text = "Kasir : " + nama;

            dataGridView1.Columns.Add("", "Kode Barang");
            dataGridView1.Columns.Add("", "Nama Barang");
            dataGridView1.Columns.Add("", "Jumlah");
            dataGridView1.Columns.Add("", "Diskon");
            dataGridView1.Columns.Add("", "Harga Barang");
            dataGridView1.Columns.Add("", "Total");
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].FillWeight = 150;
            dataGridView1.Columns[1].FillWeight = 200;
            dataGridView1.Columns[2].FillWeight = 40;
            dataGridView1.Columns[3].FillWeight = 40;
            dataGridView1.Columns[4].FillWeight = 100;
            dataGridView1.Columns[5].FillWeight = 100;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            tampilData(invoice);
        }

        private void tampilData(string invoice)
        {
            MySqlConnection con = Koneksi.koneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM detail_pembelian WHERE invoice = '" + invoice + "'", con);
            MySqlDataReader read = cmd.ExecuteReader();

            long totalTransaksi = 0;

            while (read.Read())
            {
                int qty = Convert.ToInt32(read["jumlah_barang"]);
                int diskon = Convert.ToInt32(read["diskon_barang"]);
                long harga = Convert.ToInt64(read["harga_barang"]);
                long total = harga * qty - harga * qty * diskon / 100;

                totalTransaksi += total;

                dataGridView1.Rows.Add(new object[] {
                    read["kode_barang"], read["nama_barang"], qty, diskon, String.Format(idID, "{0:#,##0}", harga),
                    String.Format(idID, "{0:#,##0}", total)
                });
            }

            dataGridView1.Rows.Add(new object[] { "", "", "", "", "Total", String.Format(idID, "{0:#,##0}", totalTransaksi)});
            con.Close();
        }
    }
}
