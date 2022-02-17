using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimari
{
    public partial class Form1 : Form
    {
        int i = 0, brc = 0,Pun=0;
        string[] OlusturulanKartNolar = new string[0];
        string[] OlusturulanKarttipler = new string[0];
        string[] OlusturulanKartsahip = new string[0];
        string[] OlusturulanKartsontarih = new string[0];
        int[] OlusturulanKartborc = new int[0];
        int[] OlusturulanKartpuan = new int[0];
        int[] OlusturulanKartcvv = new int[0];
        int[] OlusturulanKartlimit = new int[0];
        //Tum degiskenler icin birer dizi tanimlaniyor. Bu diziler olusturulacak degiskenleri sistemde tutabilmek icin olusturuluyor.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (adtxt.Text == "" && soyadtxt.Text == "")
            {
                
                MessageBox.Show("!!!Ad Soyad Giriniz!!!");
                //Eger kullanici ad soyad girmediyse uyari veriyor.
            }
            else
            {
                if(KrtTipBox.SelectedIndex == 0 || KrtTipBox.SelectedIndex == 1 || KrtTipBox.SelectedIndex == 2)
                {
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label17.Visible = true;
                    harcamagrup.Visible = true;
                    kartdurumgrup.Visible = true;
                    odemegrup.Visible = true;
                    //Kart tipi secildiyse kart bilgilerini ekrana yazdiracak labellar,kart durumu, kart ön izleme, harcama ve odeme bolumleri görünür hale geliyor.
                }
                else
                {
                    MessageBox.Show("Lütfen kart tipi seçiniz.");
                    //Kart tipi secilmediyse uyari veriyor.
                }
                
                Array.Resize(ref OlusturulanKartNolar, i + 1);
                Array.Resize(ref OlusturulanKarttipler, i + 1);
                Array.Resize(ref OlusturulanKartsahip, i + 1);
                Array.Resize(ref OlusturulanKartsontarih, i + 1);
                Array.Resize(ref OlusturulanKartcvv, i + 1);
                Array.Resize(ref OlusturulanKartborc, i + 1);
                Array.Resize(ref OlusturulanKartpuan, i + 1);
                Array.Resize(ref OlusturulanKartlimit, i + 1);
                //Resize komutu, dizinin boyutunu degistirmek icin kullanilir.
                //ref ile diziye yeni bir boyut tanimlaniyor ve yeni boyutun i+1 kadar olmasi saglaniyor.


                if (KrtTipBox.SelectedIndex == 0)
                {
                    //Eger kart tipi 0. indeksteki tip yani MasterCard secildiyse,
                    brc = 0;
                    Pun = 0;
                    MasterCard krt = new MasterCard();
                    //MasterCard classi kullanilarak yeni bir kart nesnesi olusturuluyor.
                    OlusturulanKartNolar[i] = krt.GetKartNo();
                    OlusturulanKarttipler[i] = krt.GetKartTipi();
                    OlusturulanKartsahip[i] = krt.GetSahipAdi(adtxt.Text) + " " + krt.GetSahipSoyadi(soyadtxt.Text);
                    OlusturulanKartsontarih[i] = krt.GetSKT();
                    OlusturulanKartcvv[i] = krt.GetCvvNo();
                    OlusturulanKartpuan[i] = krt.Borc(Pun);
                    OlusturulanKartborc[i] = krt.Borc(brc);
                    OlusturulanKartlimit[i] = krt.Limit();
                    //MasterCard classinda tanimlanan ve return ile dondurulen degiskenler burada kullaniliyor.
                    //Tum degiskenler, form uzerinden yeni eklenen degerlerle diziye ataniyor.

                    pictureBox1.Image = imageList1.Images[0];
                    label3.Text = OlusturulanKartNolar[i];
                    label4.Text = OlusturulanKartsahip[i];
                    label5.Text = OlusturulanKartsontarih[i];
                    label6.Text = Convert.ToString(OlusturulanKartcvv[i]);
                    label11.Text = Convert.ToString(OlusturulanKartborc[i]);
                    label12.Text = Convert.ToString(OlusturulanKartpuan[i]);
                    label13.Text = Convert.ToString(OlusturulanKartlimit[i]);
                    //Labellara yeni degerler yazdiriliyor.



                }
                else if (KrtTipBox.SelectedIndex == 1)
                {
                    //Eger kart tipi 1. indeksteki tip yani Visa secildiyse,
                    brc = 0;
                    Pun = 0;
                    Visa krt = new Visa();
                    //Visa classi kullanilarak yeni bir kart nesnesi olusturuluyor.
                    OlusturulanKartNolar[i] = krt.GetKartNo();
                    OlusturulanKarttipler[i] = krt.GetKartTipi();
                    OlusturulanKartsahip[i] = krt.GetSahipAdi(adtxt.Text) + " " + krt.GetSahipSoyadi(soyadtxt.Text);
                    OlusturulanKartsontarih[i] = krt.GetSKT();
                    OlusturulanKartcvv[i] = krt.GetCvvNo();
                    OlusturulanKartpuan[i] = krt.Borc(Pun);
                    OlusturulanKartborc[i] = krt.Borc(brc);
                    OlusturulanKartlimit[i] = krt.Limit();
                    //Visa classinda tanimlanan ve return ile dondurulen degiskenler burada kullaniliyor.
                    //Tum degiskenler, form uzerinden yeni eklenen degerlerle diziye ataniyor.

                    pictureBox1.Image = imageList1.Images[1];
                    label3.Text = OlusturulanKartNolar[i];
                    label4.Text = OlusturulanKartsahip[i];
                    label5.Text = OlusturulanKartsontarih[i];
                    label6.Text = Convert.ToString(OlusturulanKartcvv[i]);
                    label11.Text = Convert.ToString(OlusturulanKartborc[i]);
                    label12.Text = Convert.ToString(OlusturulanKartpuan[i]);
                    label13.Text = Convert.ToString(OlusturulanKartlimit[i]);
                    //Labellara yeni degerler yazdiriliyor.
                }
                else if (KrtTipBox.SelectedIndex == 2)
                {
                    //Eger kart tipi 2. indeksteki tip yani Aamex secildiyse,
                    brc = 0;
                    Pun = 0;
                    Amex krt = new Amex();
                    //Amex classi kullanilarak yeni bir kart nesnesi olusturuluyor.
                    OlusturulanKartNolar[i] = krt.GetKartNo();
                    OlusturulanKarttipler[i] = krt.GetKartTipi();
                    OlusturulanKartsahip[i] = krt.GetSahipAdi(adtxt.Text) + " " + krt.GetSahipSoyadi(soyadtxt.Text);
                    OlusturulanKartsontarih[i] = krt.GetSKT();
                    OlusturulanKartcvv[i] = krt.GetCvvNo();
                    OlusturulanKartpuan[i] = krt.Borc(Pun);
                    OlusturulanKartborc[i] = krt.Borc(brc);
                    OlusturulanKartlimit[i] = krt.Limit();
                    //Amex classinda tanimlanan ve return ile dondurulen degiskenler burada kullaniliyor.
                    //Tum degiskenler, form uzerinden yeni eklenen degerlerle diziye ataniyor.

                    pictureBox1.Image = imageList1.Images[2];
                    label3.Text = OlusturulanKartNolar[i];
                    label4.Text = OlusturulanKartsahip[i];
                    label5.Text = OlusturulanKartsontarih[i];
                    label6.Text = Convert.ToString(OlusturulanKartcvv[i]);
                    label11.Text = Convert.ToString(OlusturulanKartborc[i]);
                    label12.Text = Convert.ToString(OlusturulanKartpuan[i]);
                    label13.Text = Convert.ToString(OlusturulanKartlimit[i]);
                    //Labellara yeni degerler yazdiriliyor.
                }
                i += 1;
                //i arttırılıyor.
            }
        }

        private void harcamabtn_Click(object sender, EventArgs e)
            //Harca butonuna tiklandiginda,
        {
            try
            {
                brc += Convert.ToInt32(textBox1.Text);
                //textBox1'e borc yazdiriliyor.
                if (brc > OlusturulanKartlimit[i - 1])
                {
                    brc -= Convert.ToInt32(textBox1.Text);
                    MessageBox.Show("!!!Yetersiz Limit!!!");
                    //Eger harcanmak istenen miktar yani borc kart limitinden fazlaysa uyari veriyor.
                }
                else
                {
                    if (KrtTipBox.SelectedIndex == 0)
                    {
                        MasterCard krt = new MasterCard();
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                    }
                    else if (KrtTipBox.SelectedIndex == 1)
                    {
                        Visa krt = new Visa();
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                    }
                    else if (KrtTipBox.SelectedIndex == 2)
                    {
                        Amex krt = new Amex();
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                    }
                    //Secilen kart tipine göre olusturulan kart icerisinde borc islemleri yapiliyor ve
                    //karttaki para miktarindan, harcanmak istenen miktar cikartiliyor.
                    //Kart borclari bir dizi icinde saklanmaktadir.
                }
            }
            catch
            {
                MessageBox.Show("!!!Lüften Doğru Tipte Değer Girin!!!");
                //try-catch blogunda ise yanlis tipte bir deger girilirse kodun hata vermemesi icin kullaniciye uyari veriliyor.
            }
            
            
        }



        private void odebtn_Click(object sender, EventArgs e)
        //Ode butonuna tiklandiginda,
        {
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Tutar Giriniz");
                    //Odeme icin tutar girilmediyse uyari veriliyor.
                }
                else
                {
                    if(brc<Convert.ToInt32(textBox2.Text))
                    {
                        MessageBox.Show("!!!Borcunuzdan Fazla Değer Girdiniz!!!");
                        //Odemek icin borctan fazla bir deger girildiyse uyari veriliyor.
                    }
                    else
                    {
                        if (brc <= 0)
                        //Borc sifirdan kucuk veya esitse,
                        {
                            Pun += brc / 10;
                            //Odenen borcun 1/10'i hesaplanarak puana atanir.
                            brc = 0;
                            //Borc sifirlanir.

                        }
                        else
                        {
                            //Kalan borc sıfırdan büyük ise,
                            brc -= Convert.ToInt32(textBox2.Text);
                            //Odenen miktar borctan eksiltilir ve textBox2'ye yazdirilir.
                            Pun += Convert.ToInt32(textBox2.Text) / 10;
                            //Odenen miktarin 1/10'i puana eklenir.
                        }
                    }
                    

                    if (KrtTipBox.SelectedIndex == 0)
                    {
                        MasterCard krt = new MasterCard();
                        //MasterCard classi kullanilarak kart nesnesi olusturuluyor.
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        OlusturulanKartpuan[i - 1] = krt.GetPuan(Pun);
                        //MasterCard classindan çekilen Borc ve GetPuan ozellikleri,
                        //OlusturulanKartBorc ve OlusturulanKartPuan dizilerine atanir.
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                        label12.Text = Convert.ToString(OlusturulanKartpuan[i - 1]);
                        //Labellarda bu ozellikler yazdirilir.
                    }
                    else if (KrtTipBox.SelectedIndex == 1)
                    {
                        Visa krt = new Visa();
                        //Visa classi kullanilarak kart nesnesi olusturuluyor.
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        OlusturulanKartpuan[i - 1] = krt.GetPuan(Pun);
                        //Visa classindan çekilen Borc ve GetPuan ozellikleri,
                        //OlusturulanKartBorc ve OlusturulanKartPuan dizilerine atanir.
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                        label12.Text = Convert.ToString(OlusturulanKartpuan[i - 1]);
                        //Labellarda bu ozellikler yazdirilir.
                    }
                    else if (KrtTipBox.SelectedIndex == 2)
                    {
                        Amex krt = new Amex();
                        //Amex classi kullanilarak kart nesnesi olusturuluyor.
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        OlusturulanKartpuan[i - 1] = krt.GetPuan(Pun);
                        //Amex classindan çekilen Borc ve GetPuan ozellikleri,
                        //OlusturulanKartBorc ve OlusturulanKartPuan dizilerine atanir.
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                        label12.Text = Convert.ToString(OlusturulanKartpuan[i - 1]);
                        //Labellarda bu ozellikler yazdirilir.
                    }
                }

            }
            catch
            {
                MessageBox.Show("!!!Lüften Doğru Tipte Değer Girin!!!");
                //try-catch blogunda ise yanlis tipte bir deger girilirse kodun hata vermemesi icin kullaniciye uyari veriliyor.
            }


        }

        

        private void puanodebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Tutar Giriniz");
                    //Odeme icin tutar girilmediyse uyari veriliyor.
                }
                else
                {
                    if(Pun<Convert.ToInt32(textBox2.Text))
                    {
                        MessageBox.Show("Puaninizdan Buyuk Deger girdiniz");
                        //Odemek icin puandan fazla bir deger girildiyse uyari veriliyor.
                    }
                    else
                    {
                        if (brc == 0)
                        {

                        }
                        else if (Pun <= 0)
                        {

                        }
                        else if (Pun > brc && Convert.ToInt32(textBox2.Text) > brc)
                            //Puan borctan buyukse ve odenen miktar borctan buyukse,
                        {
                            Pun -= brc;
                            //Puandan borcu cikartir ve yeni degeri puana atar.
                            brc = 0;
                            //Borcu sifirlar.
                            if (Pun < 0)
                            {
                                //Puan sifirdan kucukse eksiye dusmemesi icin puani sifirlar.
                                Pun = 0;
                            }
                        }
                        else
                        {
                            //Puan ve odenen miktar borctan buyuk degilse,
                            brc -= Convert.ToInt32(textBox2.Text);
                            //Borctan odenen miktari cikartir ve yeni degeri borca atar.
                            Pun -= Convert.ToInt32(textBox2.Text);
                            //Puandan, puan ile odenen miktari cikartir ve yeni degeri atar.
                            if (Pun < 0)
                            {
                                //Puan sifirdan kucukse eksiye dusmemesi icin puani sifirlar.
                                Pun = 0;
                            }
                        }
                    }
                    

                    if (KrtTipBox.SelectedIndex == 0)
                    {
                        MasterCard krt = new MasterCard();
                        //MasterCard classi kullanilarak kart nesnesi olusturuluyor.
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        OlusturulanKartpuan[i - 1] = krt.GetPuan(Pun);
                        //MasterCard classindan çekilen Borc ve GetPuan ozellikleri,
                        //OlusturulanKartBorc ve OlusturulanKartPuan dizilerine atanir.
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                        label12.Text = Convert.ToString(OlusturulanKartpuan[i - 1]);
                        //Labellarda bu ozellikler yazdirilir.
                    }
                    else if (KrtTipBox.SelectedIndex == 1)
                    {
                        Visa krt = new Visa();
                        //Visa classi kullanilarak kart nesnesi olusturuluyor.
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        OlusturulanKartpuan[i - 1] = krt.GetPuan(Pun);
                        //Visa classindan çekilen Borc ve GetPuan ozellikleri,
                        //OlusturulanKartBorc ve OlusturulanKartPuan dizilerine atanir.
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                        label12.Text = Convert.ToString(OlusturulanKartpuan[i - 1]);
                        //Labellarda bu ozellikler yazdirilir.
                    }
                    else if (KrtTipBox.SelectedIndex == 2)
                    {
                        Amex krt = new Amex();
                        //Amex classi kullanilarak kart nesnesi olusturuluyor.
                        OlusturulanKartborc[i - 1] = krt.Borc(brc);
                        OlusturulanKartpuan[i - 1] = krt.GetPuan(Pun);
                        //Amex classindan çekilen Borc ve GetPuan ozellikleri,
                        //OlusturulanKartBorc ve OlusturulanKartPuan dizilerine atanir.
                        label11.Text = Convert.ToString(OlusturulanKartborc[i - 1]);
                        label12.Text = Convert.ToString(OlusturulanKartpuan[i - 1]);
                        //Labellarda bu ozellikler yazdirilir.
                    }
                }
            }
            catch
            {
                MessageBox.Show("!!!Lüften Doğru Tipte Değer Girin!!!");
                //try-catch blogunda ise yanlis tipte bir deger girilirse kodun hata vermemesi icin kullaniciye uyari veriliyor.
            }


        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label17.Visible = false;
            harcamagrup.Visible = false;
            kartdurumgrup.Visible = false;
            odemegrup.Visible = false;
            //Uygulama baslatildigi zaman kart bilgileri, kart ön izleme, kart durumu, harcama ve odeme bolumleri gorunmez hale gelir.
        }
    }
}
