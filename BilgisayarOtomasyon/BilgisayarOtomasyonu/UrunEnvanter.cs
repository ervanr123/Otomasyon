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
    public partial class UrunEnvanter : Form
    {
        public UrunEnvanter()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N3TR03CT\SQLEXPRESS;Initial Catalog=BilgisayarOtomasyonu;Integrated Security=True");
        public int a = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UrunNumara_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sorgu = new SqlCommand("Select * from Urunler where Urun_Kodu='" + Convert.ToInt32(Urun_Kodu.Text) + "'", con);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                a = Convert.ToInt32(oku["Urun_Kodu"].ToString());
                txturunad.Text = oku["Urun_Adi"].ToString();
                txturunfiyat.Text = oku["Fiyat"].ToString();
                txturunfotolink.Text = oku["Foto_link"].ToString();
                txturunkategori.Text = oku["Kategori"].ToString();
                txturunmarka.Text = oku["Marka"].ToString();
                txturunozellik.Text = oku["Ozellikler"].ToString();
                txturunstok.Text = oku["Stok"].ToString();
                

            }
            oku.Close();
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void gncbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand sorgu1 = new SqlCommand("Update Urunler SET Stok=" + Convert.ToInt32(txturunstok.Text) + ",Fiyat=" + Convert.ToInt32(txturunfiyat.Text) + ", Foto_link='" + txturunfotolink.Text + "' WHERE Urun_Kodu='" + a + "'", con);
                sorgu1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guncelleme Basarili");
            }
            catch(Exception)
            {
                MessageBox.Show("Guncelleme Basarisiz");
            }
            
        }

        private void UrunEnvanter_Load(object sender, EventArgs e)
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
