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
using static AplikasiKasir.Function;

namespace AplikasiKasir
{
    public partial class Kasir : Form
    {
        MainMenu mn;
        List<List<string>> detailProduk = new List<List<string>>();
        CultureInfo idID = CultureInfo.CreateSpecificCulture("id-ID");
        int ltotal = 0;

        public Kasir(MainMenu menu)
        {
            InitializeComponent();
            lNamaKasir.Text = "Selamat Datang, " + Koneksi.Session_Username;
            mn = menu;
        }

        public void pencarian(object kode) { tKode.Text = kode.ToString(); }
            
        public void simpanData()
        {
            /**
             * Memuat invoice, nama kasir, diskon pembelian, dan total harga ke dalam tabel data_pembelian
             */

            MySqlConnection con = Koneksi.koneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) AS ROW FROM data_pembelian WHERE invoice LIKE 'Invoice" +
                DateTime.Now.ToString("y''MM''dd") + "%'", con);
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();

            string invoice = "Invoice" + DateTime.Now.ToString("y''MM''dd") + String.Format(idID, "{0:0000}",
                Convert.ToInt32(read["ROW"]) + 1);
            string namaKasir = Koneksi.Session_Username;
            int totalHarga = 0;

            for (int i = 0; i < detailProduk.Count; i++)
                totalHarga += Convert.ToInt32(detailProduk[i][5]);

            read.Close();

            cmd = new MySqlCommand("INSERT INTO data_pembelian(invoice, tanggal_transaksi, nama_kasir, total_harga) " +
                "VALUES(@invoice, @tanggal, @nama, @total)", con);
            cmd.Parameters.AddWithValue("@invoice", invoice);
            cmd.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@nama", namaKasir);
            cmd.Parameters.AddWithValue("@total", totalHarga);
            cmd.ExecuteNonQuery();

            /**
             * Loop semua data di detailPembelian sambil dimasukan ke dalam tabel detail_pembelian(invoice, kode barang,
             * harga barang, jumlah barang, diskon barang)
             */

            for (int i = 0; i < detailProduk.Count; i++)
            {
                cmd = new MySqlCommand("INSERT INTO detail_pembelian(invoice, kode_barang, nama_barang, harga_barang," +
                    " jumlah_barang, diskon_barang) VALUES(@invoice, @kode, @nama, @harga, @jumlah, @diskon)", con);
                cmd.Parameters.AddWithValue("@invoice", invoice);
                cmd.Parameters.AddWithValue("@kode", detailProduk[i][0]);
                cmd.Parameters.AddWithValue("@nama", detailProduk[i][1]);
                cmd.Parameters.AddWithValue("@harga", detailProduk[i][2]);
                cmd.Parameters.AddWithValue("@jumlah", detailProduk[i][3]);
                cmd.Parameters.AddWithValue("@diskon", detailProduk[i][4]);
                cmd.ExecuteNonQuery();
            }

            /*
             * Mempersiapkan form untuk pembelian berikutnya
             */

            detailProduk.Clear();
            dataGridView1.Rows.Clear();
            lTotal.Text = "0";
            tKode.Focus();

            con.Close();
        }

        private void keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C || e.KeyCode == Keys.F12)
                button1_Click(sender, e);
            if (e.KeyCode == Keys.F2)
                button2_Click(sender, e);
            if (e.KeyCode == Keys.F3)
                button4_Click(sender, e);
            if (e.KeyCode == Keys.Enter)
                button3_Click(sender, e);
            if (e.KeyCode == Keys.F1)
                button5_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e) 
        { 
            if (detailProduk.Count.Equals(0))
                Logout(mn);
            else
            {
                DialogResult dr = MessageBox.Show("Masih Terdapat Data Pembelian, Apakah Anda Yakin Ingin Keluar?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.Equals(DialogResult.Yes))
                    Logout(mn);
                else
                    tKode.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PencarianProduk pp = new PencarianProduk(this);
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!tKode.Text.Equals(""))
            {
                //Cek kode produk
                MySqlConnection con = Koneksi.koneksi();
                MySqlCommand cmd = new MySqlCommand("SELECT nama_produk, harga_produk FROM data_produk WHERE kode_produk = '" +
                    tKode.Text + "'", con);
                MySqlDataReader read = cmd.ExecuteReader();
                if (!read.HasRows)
                {
                    MessageBox.Show("Kode Produk Yang Anda Masukan Salah!!", "Error");
                    tKode.Focus();
                }
                else
                {
                    //Masukin dalam list detailProduk[i][kode_produk, nama_produk, harga_produk, Qty, Diskon, Total]
                    read.Read();

                    string namaProduk = read["nama_produk"].ToString();
                    int hargaProduk = Convert.ToInt32(read["harga_produk"].ToString());
                    int qty = Convert.ToInt32(nudQty.Value);
                    int diskon = Convert.ToInt32(nudDiskon.Value);
                    int total = hargaProduk * qty - hargaProduk * qty * diskon / 100;

                    detailProduk.Add(new List<string>());
                    detailProduk[detailProduk.Count - 1].Add(tKode.Text);
                    detailProduk[detailProduk.Count - 1].Add(namaProduk);
                    detailProduk[detailProduk.Count - 1].Add(hargaProduk.ToString());
                    detailProduk[detailProduk.Count - 1].Add(qty.ToString());
                    detailProduk[detailProduk.Count - 1].Add(diskon.ToString());
                    detailProduk[detailProduk.Count - 1].Add(total.ToString());

                    dataGridView1.Rows.Add(new object[] {
                    tKode.Text, namaProduk, String.Format(idID, "{0:#,##0}", hargaProduk),
                    qty, diskon, String.Format(idID, "{0:#,##0}", total)
                });

                    //Memperlihatkan total di label lTotal

                    for (int i = 0; i < detailProduk.Count; i++)
                    {
                        ltotal += Convert.ToInt32(detailProduk[i][5]);
                    }

                    string test = String.Format(idID, "{0:#,##0}", ltotal);

                    lTotal.Text = test;
                    tKode.Text = "";
                    tKode.Focus();
                    nudQty.Value = 1;
                    nudDiskon.Value = 0;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Masukan Kode Produk Anda!", "Masukan Data", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                tKode.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!detailProduk.Count.Equals(0))
            {
                Pembayaran pb = new Pembayaran(this, ltotal);
                pb.Show();
            }
            else 
            {
                MessageBox.Show("Tidak Terdapat Data Pembelian!", "Tidak Ada Data");
                tKode.Focus();
            }                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!detailProduk.Count.Equals(0))
            {
                DialogResult dr = MessageBox.Show("Masi Terdapat Transaksi, Apakah Anda Yakin Ingin Menghapusnya?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr.Equals(DialogResult.Yes))
                {
                    detailProduk.Clear();
                    dataGridView1.Rows.Clear();
                    lTotal.Text = "0";
                    tKode.Focus();
                }
            }
        }
    }
}
