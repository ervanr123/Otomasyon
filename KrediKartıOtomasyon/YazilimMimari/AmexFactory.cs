using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    class AmexFactory : KartFactory
    //KartFactory sinifi BaseClass olarak kullaniliyor ve AmexFactory sinifi oradan miras aliyor.
    {
        protected override KrediKarti Kart()
        {
            KrediKarti kart = new Amex();
            return kart;
            //KartFactory soyut sinifinda olusturulan Kart() nesnesi kullanılarak Amex karti icin nesne olusturuluyor.
        }
    }
}
