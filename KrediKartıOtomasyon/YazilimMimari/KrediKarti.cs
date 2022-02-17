using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public interface KrediKarti
    //KrediKarti interface sinifi olusturuluyor alt siniflardan miras alinarak kullanilmak uzere gerekli degiskenler tanimlaniyor.
    {
        string GetKartTipi();
        string GetKartNo();
        int GetCvvNo();
        string GetSahipAdi(string a);
        string GetSahipSoyadi(string a);
        string GetSKT();
        int GetPuan(int a);
        int Borc(int a);
    }
}
