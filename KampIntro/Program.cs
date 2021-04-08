using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety= tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu.");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi+" Kursa kayıtlı öğrenci vardır.");
            Console.WriteLine(faizOranı);


        }
    }
}
