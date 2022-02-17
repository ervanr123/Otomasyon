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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection Bglnti = new SqlConnection(@"Data Source=LAPTOP-N3TR03CT\SQLEXPRESS;Initial Catalog=BilgisayarOtomasyonu;Integrated Security=True");
        private void meklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Bglnti.Open();
                int k = 1;
                SqlCommand sorgu = new SqlCommand("Select * from Müsteriler where TC_No='" +MTC.Text  + "'", Bglnti);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {
                    if(oku["TC_No"].ToString() == MTC.Text)
                    {
                        k = 0;
                        MessageBox.Show("Bu Musteri Mevcuttur.");
                    }
                }
                oku.Close();
                Bglnti.Close();
                if(k==1)
                {
                    if (MTC.Text == "" || Msoyad.Text == "" || Mad.Text == "" || Mtelefon.Text == "" || Mtelefon.Text == "")
                    {
                        MessageBox.Show("Alanlar Boş Bırakılamaz.");
                    }
                    else
                    {
                        Bglnti.Open();
                        SqlCommand srg2 = new SqlCommand("Insert into Müsteriler (Ad,Soyad,Telefon,TC_No) values ('" + Mad.Text + "','" + Msoyad.Text + "','" + Mtelefon.Text + "','" + MTC.Text + "')", Bglnti);
                        srg2.ExecuteNonQuery();
                        Bglnti.Close();
                        MessageBox.Show("Ekleme Başarılı.");
                    }
                    
                }
                

            }
            catch(Exception)
            {
                MessageBox.Show("Ekleme Başarısız.");
            }
            
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void ana_Click(object sender, EventArgs e)
        {
            AnaSayfa asf = new AnaSayfa();
            asf.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Mad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
