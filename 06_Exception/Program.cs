using System;

namespace _06_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = TamsayiOku("Sayi1 giriniz");
                int b = TamsayiOku("Sayı 2 giriniz");
                int toplam = a + b;
                Console.WriteLine($"toplam={toplam}");

                //Console.WriteLine("Sayi1 giriniz:");
                //int a = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Sayi2 giriniz:");
                //int b = Convert.ToInt32(Console.ReadLine());

                //int toplam = a + b;

                //Console.WriteLine($"Sayıların toplamı={toplam}"); 
            }



            #region tryCatch
            //int outSayi = 0;
            //int donenDeger = OutParam(out outSayi);
            //try
            //{
            //    Console.WriteLine("Hello World!");
            //    int a = 5;
            //    Console.WriteLine("Sayı giriniz:");
            //    string deger = Console.ReadLine();

            //    if (!int.TryParse(deger, out a))
            //    {
            //        Console.WriteLine("tam sayı girmediniz.");
            //    }

            //    Console.WriteLine("Sayı2 giriniz:");
            //    string deger1 = Console.ReadLine();

            //    int b = Convert.ToInt32(deger1);

            //    Console.WriteLine(a + b);
            //}
            //catch(Exception ex)
            //{

            //  //  Console.WriteLine("Beklenmedik bir hata::");
            //}
            //Console.ReadLine();
            #endregion
        }

        static int TamsayiOku(string aciklama = "Sayı giriniz:")
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(aciklama);
                    int sonuc = Convert.ToInt32(Console.ReadLine());
                    return sonuc;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş");
                    continue;
                }
            }
            
        }
        static int OutParam(out int sayi)
        {
            int a = 5;
            sayi = 6;
            return a;

        }
    }
}
