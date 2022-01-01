using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeritabaniKayitGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = ""; // çift tırnak içine kendi database yolunuzu eklemeniz gerekiyor
        SqlConnection connect = new SqlConnection(constring);

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                string kayit = "insert into kayitli (kullaniciAdi,sifre) values(@kullaniciAdi,@sifre)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@kullaniciAdi", tbKayitKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", tbKayitSifre.Text);

                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Kayıt Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Meydana Geldi" + ex.Message);
            }
        }
        KullaniciGiris kullaniciDegisken = new KullaniciGiris();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciDegisken.kullanici(tbGirisKullaniciAdi, tbGirisSifre);
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            sifremiUnuttum sifreGuncelle = new sifremiUnuttum();
            sifreGuncelle.ShowDialog();
        }
    }
}
