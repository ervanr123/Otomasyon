using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BilgisayarOtomasyonu
{
    public partial class Satıslar : Form
    {
        public Satıslar()
        {
            InitializeComponent();
            string sorgu3 = "Select * From Müsteriler";
            musterisec(müsteri, sorgu3);
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-N3TR03CT\SQLEXPRESS;Initial Catalog=BilgisayarOtomasyonu;Integrated Security=True");

        public void urunsec(TextBox kod, TextBox kategori, TextBox marka,TextBox urun,Label fiyat,Label stok,PictureBox urunfoto, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kategori.Text = oku["Kategori"].ToString();
                marka.Text = oku["Marka"].ToString();
                urun.Text = oku["Urun_Adi"].ToString();
                fiyat.Text = oku["Fiyat"].ToString();
                stok.Text = oku["Stok"].ToString();
                urunfoto.ImageLocation = oku["Foto_link"].ToString();
            }
            baglanti.Close();
        }

        public void musterisec(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                combo.Items.Add(oku["TC_No"].ToString());
            }
            baglanti.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void müsteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void satıs_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void urunfoto_Click(object sender, EventArgs e)
        {

        }

        private void fiyat_Click(object sender, EventArgs e)
        {

        }
        private void ekle(SqlCommand komut,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void stsonay_Click(object sender, EventArgs e)
        {
            string islem_tarihi = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sorgu4 = "Insert into Siparis (TC_No,Urun_Kodu,Adet,Siparis_Tarihi,Kargo_Adresi) values (@TC_No,@Urun_Kodu,@Adet,@Siparis_Tarihi,@Kargo_Adresi)";
            SqlCommand komut2 = new SqlCommand();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Select * From Müsteriler where TC_No like '" + müsteri.SelectedItem + "'  ", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();
            string Ad = "", Soyad = "", musteri;
            while (oku.Read())
            {
                Ad = oku["Ad"].ToString();
                Soyad = oku["Soyad"].ToString();
            }
            musteri = Ad + " " + Soyad;
            baglanti.Close();
            komut2.Parameters.AddWithValue("@TC_No", Convert.ToInt32(kod.Text.ToString()));
            komut2.Parameters.AddWithValue("@Urun_Kodu", Convert.ToInt32(kod.Text.ToString()));
            komut2.Parameters.AddWithValue("@Adet", Convert.ToInt32(urnadet.Text.ToString()));
            komut2.Parameters.AddWithValue("@Siparis_Tarihi", islem_tarihi);
            komut2.Parameters.AddWithValue("@Kargo_Adresi", adres.Text);
            if (Convert.ToInt32(urnadet.Text.ToString()) == 0 || kod.Text == "" || adres.Text == "")
            {
                MessageBox.Show("Sipariş Alınamadı.");
            }
            else
            {
                ekle(komut2, sorgu4);
                MessageBox.Show("Sipariş Alındı.");
                SqlCommand komut3 = new SqlCommand();
                string sorgu5 = "Insert into Siparis_Liste (Musteri,Kategori,Marka,Fiyat,Urun_Kodu,Adet,Tarih,Adres) values (@Musteri,@Kategori,@Marka,@Fiyat,@Urun_Kodu,@Adet,@Tarih,@Adres)";
                komut3.Parameters.AddWithValue("@Urun_Kodu", kod.Text);
                komut3.Parameters.AddWithValue("@Adet", urnadet.Text);
                komut3.Parameters.AddWithValue("@Tarih", islem_tarihi);
                komut3.Parameters.AddWithValue("@Adres", adres.Text);
                komut3.Parameters.AddWithValue("@Musteri", musteri);
                komut3.Parameters.AddWithValue("@Marka", marka.Text);
                komut3.Parameters.AddWithValue("@Kategori", kategori.Text);
                komut3.Parameters.AddWithValue("@Fiyat", fiyat.Text);
                ekle(komut3, sorgu5);
                Siparisler siparis = new Siparisler();
                siparis.goster();
                int sayi = 0;
                sayi = Convert.ToInt32(stok.Text.ToString()) - Convert.ToInt32(urnadet.Text.ToString());


                string sorgu6 = "Update Urunler set Stok='" + sayi + "' where Urun_Kodu like '" + Convert.ToInt32(kod.Text.ToString()) + "' ";
                SqlCommand komut4 = new SqlCommand();
                ekle(komut4, sorgu6);
                stok.Text = sayi.ToString();

            }
            
        }

        private void kod_TextChanged(object sender, EventArgs e)
        {
            if (kod.Text == "") foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "Select * From Urunler Where Urun_Kodu like '" + kod.Text + "'";
            urunsec(kod, kategori, marka, urun, fiyat,stok,urunfoto, sorgu2);
        }

        private void kategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void marka_TextChanged(object sender, EventArgs e)
        {

        }

        private void urun_TextChanged(object sender, EventArgs e)
        {

        }

        private void stok_Click(object sender, EventArgs e)
        {

        }

        private void ana_Click(object sender, EventArgs e)
        {
            AnaSayfa asf = new AnaSayfa();
            asf.Show();
            this.Hide();
        }

        private void Satıslar_Load(object sender, EventArgs e)
        {

        }
    }
}
