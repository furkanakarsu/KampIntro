﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla( int sayi1,int sayi2)
        {
            int Toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç: "+Toplam);
        }

        public void Cikart(int sayi1,int sayi2)
        {
            int Cikan = sayi1 - sayi2;
            Console.WriteLine("Sonuç: " + Cikan);

        }
    }
}
