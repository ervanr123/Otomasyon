using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public class Visa : KrediKarti
    //KrediKarti sinifi BaseClass olarak kullanılıyor ve Visa sinifi oradan miras aliyor.
    {
        public string GetKartTipi()
        {
            return "Visa";
            //Kart tipi tanimlanıyor ve return ile tip donduruluyor.
        }
        public string GetKartNo()
        //Kart numarasi tanimlaniyor.
        {
            string Vkartno = "4";
            //Kartnumarasi icin bir Vkartno degiskeni tanimlaniyor ve ilk rakaminin 4 olmasi kuralini saglamak icin 4 rakami string'in icerisine ataniyor.
            Random rasgele = new Random();
            for (int i = 0; i < 18; i++)
            //18 karakter icermesi icin bir for döngüsü olusturuluyor.
            {

                if (i == 3 || i == 8 || i == 13)
                {
                    Vkartno += " ";
                    //Kart numarasinda 5 karakterde bir bosluk olmasi icin if kodu kullaniliyor ve bosluklar da string icerisine ataniyor.
                }
                else
                {
                    Vkartno += Convert.ToString(rasgele.Next(1, 10));
                    //Kart numarasinin geri kalan rakamlari random olarak uretiliyor ve string icerisine ataniyor.
                }

            }
            return Vkartno;
            //Vkartno string'i kullanilmak uzere return ile donduruluyor.
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
            return "01/2025";
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
