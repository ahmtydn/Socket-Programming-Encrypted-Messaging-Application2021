using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPN_Algoritması
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMetinSifreleme_Click(object sender, EventArgs e)
        {
            frmMetinSifrele metin_sifrele = new frmMetinSifrele();
            metin_sifrele.Show();
        }

        private void btnSifrelenmisMetinCoz_Click(object sender, EventArgs e)
        {
            frmMetinCöz metin_coz = new frmMetinCöz();
            metin_coz.Show();
        }
    }
}
