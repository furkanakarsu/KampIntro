using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*                                  DEĞER TİPLER
                                                       1)int
                                                       2)decimal
                                                       3)float
                                                       4)double
                                                       5)bool    
            değer tipler STACK te depolanır.
            
            heap ta depolanır ve bir adres ile belirlenir.
                                                                             REFERANS TİPLER
                                                                              1)Array
                                                                              2)class
                                                                              3)interface
             */


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            Console.WriteLine("-------------------------------");




            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);
        }
    }
}
