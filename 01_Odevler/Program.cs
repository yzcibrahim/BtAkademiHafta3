using System;

namespace _01_Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Odevler!");
            Odev1();
           
        }

        static void Odev1()
        {
            while (true)
            {
                Console.WriteLine("Mükemmelliği kontorl Edilecek Sayı Giriniz: Çıkış için C");
                string deger = Console.ReadLine();
                if (deger == "C")
                    break;

                int sayi = Convert.ToInt32(deger);
                if (MukemmelMi(sayi))
                {
                    Console.WriteLine("Sayı Mükemmeldir");
                }
                else
                {
                    Console.WriteLine("Sayı Mükemmel değildir.");
                }

            }
        }

        static bool MukemmelMi(int pSayi)
        {
            int index = 0;
            int toplam = 0;
            for (int i = 1; i < pSayi; i++)
            {
                if (pSayi % i == 0)
                {
                    toplam += i;
                    index++;
                }
            }

            return toplam == pSayi;
            //if (toplam == pSayi)
            //    return true;
            //else
            //    return false;

        }

    }
}
