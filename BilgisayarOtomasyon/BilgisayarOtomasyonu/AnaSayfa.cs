using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void urnekle_Click(object sender, EventArgs e)
        {
            UrunEkle u1 = new UrunEkle();
            u1.Show();
            this.Hide();
        }

        private void siparisliste_Click(object sender, EventArgs e)
        {
            Siparisler sp1 = new Siparisler();
            sp1.Show();
            this.Hide();
        }

        private void müsteriekle_Click(object sender, EventArgs e)
        {
            MusteriEkle m1 = new MusteriEkle();
            m1.Show();
            this.Hide();
        }

        private void stslr_Click(object sender, EventArgs e)
        {
            Satıslar st1 = new Satıslar();
            st1.Show();
            this.Hide();
        }

        private void cksbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void envanter_Click(object sender, EventArgs e)
        {
            UrunEnvanter ue1 = new UrunEnvanter();
            ue1.Show();
            this.Hide();
        }
    }
}
