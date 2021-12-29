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
    public partial class frmMetinSifrele : Form
    { 
        private Stopwatch stopWatch = new Stopwatch();
        public static string anahtar;
        public frmMetinSifrele()
        {
            InitializeComponent();
        }
        private void btnMetinSifrele_Click(object sender, EventArgs e)
        {
            string girilecek_metin = txtGirilecekMetin.Text;
            anahtar = txtAnahtar.Text;
            stopWatch.Start();
            Metin sifrele = new Metin(girilecek_metin, anahtar);
            txtSifrelenmisMetin.Text = sifrele.MetinSifreleme();
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            sifrele.Saniye = t.TotalMilliseconds.ToString();
            txtCalismaZamani.Text = sifrele.Saniye.ToString();
        }
        private void txtGirilecekMetin_Leave(object sender, EventArgs e)
        {
            if (txtGirilecekMetin.Text == "")
            {
                MessageBox.Show("Lütfen bir metin giriniz.");
                txtGirilecekMetin.Focus();
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
        private void btnSifrelenmisMetinKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSifrelenmisMetin.Text);
            MessageBox.Show("Şifrelenmiş metin kopyalanmıştır.");
            
        }




    }
}
