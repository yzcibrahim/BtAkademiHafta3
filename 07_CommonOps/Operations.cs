using System;

namespace _07_CommonOps
{
    public class Operations
    {
        public static int IntOku(string aciklama="Sayı giriniz.")
        {
            while (true)
            {
                Console.WriteLine(aciklama);
                string deger = Console.ReadLine();
                int result = 0;
                if (int.TryParse(deger, out result))
                {
                    return result;
                }
            }
        }
    }
}
