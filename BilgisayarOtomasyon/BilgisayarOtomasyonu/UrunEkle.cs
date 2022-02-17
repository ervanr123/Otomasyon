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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N3TR03CT\SQLEXPRESS;Initial Catalog=BilgisayarOtomasyonu;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void UrunEkleBtn_Click(object sender, EventArgs e)
        {
            if((UrunNumara.Text == "") || (txturunad.Text=="")||(txturunfiyat.Text=="") || (txturunfotolink.Text == "") || (txturunkategori.Text == "") || (txturunmarka.Text == "") || (txturunozellik.Text == "") || (txturunstok.Text == ""))
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz");
            }
            else
            {
                con.Open();
                int a = 1;
                SqlCommand sorgu = new SqlCommand("Select * from Urunler where Urun_Kodu='"+ Convert.ToInt32(UrunNumara.Text) + "'", con);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {
                    if(oku["Urun_Kodu"].ToString()== UrunNumara.Text)
                    {
                        a = 0;
                        MessageBox.Show("Bu Urun Mevcuttur Lutfen Envanter Bolumunden Isleme Devam Ediniz");
                    }
                }
                oku.Close();
                if(a==1)
                {
                    SqlCommand sorgu1 = new SqlCommand("Insert into Urunler (Urun_Kodu,Urun_Adi,Kategori,Marka,Stok,Fiyat,Foto_link,Ozellikler) values ('" + Convert.ToInt32(UrunNumara.Text) + "','" + txturunad.Text + "','" + txturunkategori.Text + "','" + txturunmarka.Text + "'," + Convert.ToInt32(txturunstok.Text) + "," + Convert.ToInt32(txturunfiyat.Text) + ",'" + txturunfotolink.Text + "','" + txturunozellik.Text + "')", con);
                    sorgu1.ExecuteNonQuery();
                    MessageBox.Show("Urun basarili sekilde eklendi.");
                }
                con.Close();
                UrunNumara.Clear();
                txturunad.Clear();
                txturunfiyat.Clear();
                txturunfotolink.Clear();
                txturunkategori.Text = "";
                txturunmarka.Text="";
                txturunozellik.Clear();
                txturunstok.Clear();                
            }
        }

        private void ana_Click(object sender, EventArgs e)
        {
            AnaSayfa asf = new AnaSayfa();
            asf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picturebox1.ImageLocation = openFileDialog1.FileName;
            txturunfotolink.Text = openFileDialog1.FileName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
