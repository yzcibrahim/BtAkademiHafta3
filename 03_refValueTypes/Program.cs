using System;

namespace _03_refValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
          //  valueType
            int a = 5;
            int b = a;
            Console.WriteLine($"a={a} b={b}");
            a = 8;
            Console.WriteLine($"a={a} b={b}");


            //
            Kisi k1 = new Kisi();
            k1.Sayi = 5;
            Kisi k2 = k1;
            Console.WriteLine($"k1 sayısı={k1.Sayi} k2 saısı={k2.Sayi}");

            k1.Sayi = 8;
            Console.WriteLine($"k1 sayısı={k1.Sayi} k2 saısı={k2.Sayi}");


        }
    }
}
