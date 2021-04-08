using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetMenager
    {
        //namein convention
        //syntax=yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler sepete eklendi:" + urun.UrunAd);
        }

        //Geliştirmesi zor olan yöntem 1 parametre eklendiği zaman bu metodun kullanıldığı her yer düzeltilmeli.
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler sepete eklendi:" + urunAdi);

        }
    }
}
