using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public class MasterCard : KrediKarti
    //KrediKarti sinifi BaseClass olarak kullanılıyor ve MasterCard sinifi oradan miras aliyor.
    {
        public string GetKartTipi()
        {
            return "MasterCard";
            //Kart tipi tanimlanıyor ve return ile tip donduruluyor.
        }
        public string GetKartNo()
        //Kart numarasi tanimlaniyor.
        {
            string Mkartno = "5";
            //Kartnumarasi icin bir Mkartno degiskeni tanimlaniyor ve ilk rakaminin 5 olmasi kuralini saglamak icin 5 rakami string'in icerisine ataniyor.
            Random rasgele = new Random();
            for (int i = 0; i < 18; i++)
            {
                //18 karakter icermesi icin bir for döngüsü olusturuluyor.

                if (i == 3 || i == 8 || i == 13)
                {
                    Mkartno += " ";
                    //Kart numarasinda 5 karakterde bir bosluk olmasi icin if kodu kullaniliyor ve bosluklar da string icerisine ataniyor.
                }
                else if (i == 0)
                {
                    Mkartno += Convert.ToString(rasgele.Next(1, 6));
                }
                else
                {
                    Mkartno += Convert.ToString(rasgele.Next(1, 10));
                    //Kart numarasinin geri kalan rakamlari random olarak uretiliyor ve string icerisine ataniyor.
                }

            }
            return Mkartno;
            //Mkartno string'i kullanilmak uzere return ile donduruluyor.
        }
        public int GetCvvNo()
        //CVV numarasi tanimlaniyor.
        {
            Random rasgele = new Random();

            return rasgele.Next(100, 1000);
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
            return "01/2026";
            //Kartin son kullanma tarihi tanimlaniyor ve donduruluyor.
        }
        public int GetPuan(int a)
        {
            int puan = 0 + a;
            return puan;
            //Kartin icersine puan tanimlaniyor ve daha sonra kullanilmak uzere donduruluyor.
        }
        public int Borc(int a)
        {
            int borc = 0 + a;

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
