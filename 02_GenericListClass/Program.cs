using System;
using System.Collections.Generic;

namespace _02_GenericListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen pozitif tam sayıları bir listeye ekleyen 
            //veya listeden çıkarabilen ve listeyi yazdırabilen bir uygulama yazalım.
            List<int> degerler = new List<int>();
            while (true)
            {
                Console.WriteLine("listeye eklemek için e listeden çıkarmak için c giriniz. listeyi yazdırmak için Y, çıkış için X");
                string islem = Console.ReadLine();
                if (islem == "X")
                {
                    break;
                }
                if (islem.ToUpper() == "E")
                {
                    degerler = DegerEkle(degerler);
                }
                else if (islem.ToUpper() == "C")
                {
                    degerler = DegerCikar(degerler);
                }
                else if (islem.ToUpper() == "Y")
                {
                    YazdirListe(degerler);
                }
            }
         }
        static void YazdirListe(List<int> liste)
        {
            liste.Sort();
            
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
        }
        static List<int> DegerCikar(List<int> pDegerler)
        {
            Console.WriteLine("çıkarmak istediğiniz sayıyı giriniz:");
            int degisken = Convert.ToInt32(Console.ReadLine());
            if (pDegerler.Remove(degisken))
            {
                Console.WriteLine($"{degisken} değeri silindi");
            }
            else
            {
                Console.WriteLine($"{degisken} değeri bulunamadı");
            }
            return pDegerler;
        }
        static List<int> DegerEkle(List<int> pDegerler)
        {
            Console.WriteLine("eklemek istediğiniz sayıyı giriniz:");
            int degisken = Convert.ToInt32(Console.ReadLine());
            pDegerler.Add(degisken);
            // Console.WriteLine(degisken+" Değeri eklendi");
            Console.WriteLine($"{degisken} Değeri eklendi");
            return pDegerler;
        }

    }
}
