using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace SPN_Algoritması
{
    public partial class frmMetinCöz : Form
    {
        private Stopwatch stopWatch = new Stopwatch();
        public frmMetinCöz()
        {
            InitializeComponent();
        }

        private void btnSifrelenmisMetinCoz_Click(object sender, EventArgs e)
        {
            string cozülecek_metin = txtCözülecekMetin.Text;
            string anahtar = txtAnahtar.Text;
            if (frmMetinSifrele.anahtar == anahtar)
            { 
            stopWatch.Start();
            Metin sifrelenmis = new Metin(cozülecek_metin, txtAnahtar.Text);
            txtCozülmüsMetin.Text = sifrelenmis.MetinCozme();
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            sifrelenmis.Saniye = t.TotalMilliseconds.ToString();
            txtCalismaZamani.Text = sifrelenmis.Saniye.ToString();
            }
            else
            {
                txtAnahtar.Text = "";
                txtAnahtar.Focus();
                MessageBox.Show("Farklı bir anahtar girdiniz.");
            }
        }
        private void txtAnahtar_Leave(object sender, EventArgs e)
        {
            if (txtAnahtar.Text == "")
            {
                MessageBox.Show("Lütfen bir anahtar giriniz.");
                txtAnahtar.Focus();
            }
        }
        private void btnSifrelenmisMetinYapıştır_Click(object sender, EventArgs e)
        {
            txtCözülecekMetin.Text = Clipboard.GetText();
            MessageBox.Show("Çözüzelecek metin yapıştırılmıştır.");
        }

        private void txtCözülecekMetin_Leave(object sender, EventArgs e)
        {
            btnSifrelenmisMetinYapıştır_Click(btnSifrelenmisMetinYapıştır,new EventArgs());
        }
    }
}
