using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public class MasterCardFactory : KartFactory
    //KartFactory sinifi BaseClass olarak kullaniliyor ve MasterCardFactory sinifi oradan miras aliyor.
    {
        protected override KrediKarti Kart()
        {
            KrediKarti kart = new MasterCard();
            return kart;
            //KartFactory soyut sinifinda olusturulan Kart() nesnesi kullanılarak Visa karti icin nesne olusturuluyor.
        }

    }
}
