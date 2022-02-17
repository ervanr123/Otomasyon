using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public abstract class KartFactory
    //KartFactory soyut sinifi ile Factory Pattern kullanimi saglanıyor.
    {
        protected abstract KrediKarti Kart();
        public KrediKarti KartOlustur()
        {
            return this.Kart();
            //Alt siniflarda kullanşlacak Kart() nesnesi burada olusturuluyor.
        }

    }
}
