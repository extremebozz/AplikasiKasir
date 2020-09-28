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
    public partial class Pembayaran : Form
    {
        Kasir kasir;
        long totalBelanja, bayar;
        CultureInfo idID = CultureInfo.CreateSpecificCulture("id-ID");

        public Pembayaran(Kasir ks, int total)
        {
            InitializeComponent();
            kasir = ks;
            totalBelanja = total;
            lTotalHargaBelanja.Text = string.Format(idID, "{0:#,##0}", totalBelanja);
            tBayar.Focus();
        }

        private void keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.Enter:
                    bBayar_Click(sender, e);
                    break;
            }
        }

        private void tBayar_KeyUp(object sender, KeyEventArgs e)
        {            
            try
            {
                int posisiLama = tBayar.Text.Length;
                int posisiKursor = tBayar.SelectionStart;
                bayar = Convert.ToInt64(Regex.Replace(tBayar.Text, @"[\W+\.~]", ""));
                tBayar.Text = string.Format(idID, "{0:#,##0}", bayar);
                int posisiBaru = tBayar.Text.Length;
                tBayar.SelectionStart = posisiBaru - posisiLama + posisiKursor;
                lKembali.Text = string.Format(idID, "{0:#,##0}", (bayar - totalBelanja));
            } catch { }
        }

        private void bKembali_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bBayar_Click(object sender, EventArgs e)
        {
            if (bayar >= totalBelanja)
            {
                kasir.simpanData();
                Close();
            }
        }
    }
}
