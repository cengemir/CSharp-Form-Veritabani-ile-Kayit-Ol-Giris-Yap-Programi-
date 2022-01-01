using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeritabaniKayitGiris
{
    class KullaniciGiris
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQGMC203\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        GirisYapildi giris = new GirisYapildi();

        public SqlDataReader kullanici(TextBox kullaniciAdi, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from kayitli where kullaniciAdi = '" + kullaniciAdi.Text + "'";
            read = komut.ExecuteReader();

            if (read.Read() == true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    giris.ShowDialog();
                }
                else
                    MessageBox.Show("Şifreniz Yalnış. Lütfen Kontrol Ediniz.");
            }
            else 
                MessageBox.Show("Kullanıcı Adınız Yalnış. Lütfen Kontrol Ediniz.");

            baglanti.Close();
            return read;
        }

        public void sifre(TextBox kullaniciAdi, TextBox sifre, TextBox sifreTekrar)
        {
            if (sifre.Text == sifreTekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select *from kayitli where kullaniciAdi = '" + kullaniciAdi.Text + "'", baglanti);
                read = komut.ExecuteReader();

                if (read.Read() == true)
                {
                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update kayitli set sifre = '" + sifre.Text + "' where kullaniciAdi = '" + kullaniciAdi.Text + "'", baglanti);
                        komut.ExecuteReader();
                        baglanti.Close();
                        MessageBox.Show("Şifreniz Değişti. Tekrar Giriş Yapabilirsiniz.");
                }
            }
            else 
                MessageBox.Show("Şifreler Uyuşmuyor. Lütfen Kontrol Ediniz.");

        }
    }
}
