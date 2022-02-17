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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection Baglanma = new SqlConnection(@"Data Source=LAPTOP-N3TR03CT\SQLEXPRESS;Initial Catalog=BilgisayarOtomasyonu;Integrated Security=True");

        private void grsbtn_Click(object sender, EventArgs e)
        {
            Baglanma.Open();
            SqlCommand sorgu = new SqlCommand("Select * FROM AdminGBilgi WHERE AdminMail = '" + mailtxt.Text + "' AND AdminSifre = '" + sifretxt.Text + "'", Baglanma);
            SqlDataReader dr = sorgu.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa frm1 = new AnaSayfa();
                frm1.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
            Baglanma.Close();
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
