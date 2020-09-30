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
    public partial class DataPembelian : Form
    {
        CultureInfo idID = CultureInfo.CreateSpecificCulture("id-ID");
        public DataPembelian()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("invoice", "Invoice");
            dataGridView1.Columns.Add("tanggal", "Tanggal Transaksi");
            dataGridView1.Columns.Add("nama", "Nama Kasir");
            dataGridView1.Columns.Add("total", "Total Harga");
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[0].Width = 150;
            //dataGridView1.Columns[1].Width = 150;
            //dataGridView1.Columns[2].Width = 100;
            //dataGridView1.Columns[3].Width = 100;

            tampilData();
        }

        private void tampilData()
        {
            try
            {
                MySqlConnection con = Koneksi.koneksi();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_pembelian", con);
                MySqlDataReader read = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (read.Read())
                    dataGridView1.Rows.Add(new object[]{
                    read["invoice"], Convert.ToDateTime(read["tanggal_transaksi"]).ToString("dd/MM/yyyy"), read["nama_kasir"],
                    String.Format(idID, "{0:#,##0}", Convert.ToInt64(read["total_harga"]))
                });
            } catch {}
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tampilData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];
                DetailPembelian dp = new DetailPembelian(dr.Cells[0].Value.ToString(), dr.Cells[2].Value.ToString());
                dp.Show();
            }
        }
    }
}
