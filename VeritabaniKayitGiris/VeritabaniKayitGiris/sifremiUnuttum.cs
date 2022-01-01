using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniKayitGiris
{
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }
        KullaniciGiris sifreYenile = new KullaniciGiris();
        private void btnYenile_Click(object sender, EventArgs e)
        {
            sifreYenile.sifre(tbUnuttumKullaniciAdi, tbUnuttumSifre, tbUnuttumSifreTekrar);
        }
    }
}
