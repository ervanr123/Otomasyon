using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public class Amex : KrediKarti
    //KrediKarti sinifi BaseClass olarak kullanılıyor ve Amex sinifi oradan miras aliyor.
    {
        public string GetKartTipi()
        {
            return "Amex";
            //Kart tipi tanimlanıyor ve return ile tip donduruluyor.
        }
        public string GetKartNo()
        //Kart numarasi tanimlaniyor.
        {
            string Akartno = "3";
            //Kartnumarasi icin bir Akartno degiskeni tanimlaniyor ve ilk rakaminin 3 olmasi kuralini saglamak icin 3 rakami string'in icerisine ataniyor.
            Random rasgele = new Random();
            for (int i = 0; i < 16; i++)
            {
                //16 karakter icermesi icin bir for döngüsü olusturuluyor.
                if (i == 3 || i == 10)
                {
                    Akartno += " ";
                    //Kart numarasinin 4-6-5 haneli olabilmesi icin string'in 3. ve 10. indekslerine bosluk karakteri ekleniyor.
                }
                else if (i == 0)
                {
                    int[] hane2 = new int[] {4,7};
                    //Kart numarasinin 2. rakaminin 4 ya da 7 olmasi kuralini saglamak icin deger ataniyor
                    int rindex= rasgele.Next(0, 2);
                    Akartno += Convert.ToString(hane2[rindex]);
                }
                else
                {
                    Akartno += Convert.ToString(rasgele.Next(1, 10));
                    //Kart numarasinin geri kalan rakamlari random olarak uretiliyor ve string icerisine ataniyor.
                }

            }
            return Akartno;
            //Akartno string'i kullanilmak uzere return ile donduruluyor.
        }
        public int GetCvvNo()
        //CVV numarasi tanimlaniyor.
        {
            Random rasgele = new Random();

            return rasgele.Next(1000, 10000);
            //CVV numarasini olusturmak uzere 100 ile 1000 arasinda rastgele bir sayi uretiliyor ve return ile donduruluyor.
        }
        public string GetSahipAdi(string a)
        {
            return a;
            //Kart sahibinin adi tanimlaniyor ve klavyeden alinarak buradaki string degiskenine atanacak sekilde donduruluyor.
        }
        public string GetSahipSoyadi(string a)
        {
            return a;
            //Kart sahibinin soyadi tanimlaniyor ve klavyeden alinarak buradaki string degiskenine atanacak sekilde donduruluyor.
        }
        public string GetSKT()
        {
            return "01/2027";
            //Kartin son kullanma tarihi tanimlaniyor ve donduruluyor.
        }
        public int GetPuan(int a)
        {
             int puan = 0+a;
            return puan;
            //Kartin icersine puan tanimlaniyor ve daha sonra kullanilmak uzere donduruluyor.
        }
        public int Borc(int a)
        {
             int borc = 0+a;

            return borc;
            //Kartin icersine borc tanimlaniyor ve daha sonra kullanilmak uzere donduruluyor.
        }
        public int Limit()
        {
            Random rasgele = new Random();

            return rasgele.Next(2000, 10000);
            //Kart limiti tanimlaniyor ve 2000 ile 10000 arasinda rastgele bir sayi olacak sekilde donduruluyor.
        }
    }
}
