using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public class VisaFactory : KartFactory
    //KartFactory sinifi BaseClass olarak kullaniliyor ve VisaFactory sinifi oradan miras aliyor.
    {
        protected override KrediKarti Kart()
        {
            KrediKarti kart = new Visa();
            return kart;
            //KartFactory soyut sinifinda olusturulan Kart() nesnesi kullanılarak Visa karti icin nesne olusturuluyor.
        }
    }
}
