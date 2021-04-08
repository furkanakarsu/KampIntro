using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAd = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.UrunAd = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.UrunAd);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("-------------------------METOTLAR-------------------------------");

            SepetMenager sepet = new SepetMenager();
            sepet.Ekle(urun1);
            sepet.Ekle2("Muz", "Anamur", 18);


        }
    }
}
