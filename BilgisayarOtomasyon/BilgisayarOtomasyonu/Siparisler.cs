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
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
            goster();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-N3TR03CT\SQLEXPRESS;Initial Catalog=BilgisayarOtomasyonu;Integrated Security=True");

        public void goster()
        {
            sprsler.Items.Clear();
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Select * From Siparis_Liste", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["No"].ToString();
                ekle.SubItems.Add(oku["Musteri"].ToString());
                ekle.SubItems.Add(oku["Urun_Kodu"].ToString());
                ekle.SubItems.Add(oku["Urun_Adi"].ToString());
                ekle.SubItems.Add(oku["Kategori"].ToString());
                ekle.SubItems.Add(oku["Marka"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                ekle.SubItems.Add(oku["Adet"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());

                sprsler.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void sprsler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sprsekle_Click(object sender, EventArgs e)
        {
            Satıslar st2 = new Satıslar();
            st2.Show();
            this.Hide();
        }

        private void sprsler_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ana_Click(object sender, EventArgs e)
        {
            AnaSayfa asf = new AnaSayfa();
            asf.Show();
            this.Hide();
        }
    }
}
