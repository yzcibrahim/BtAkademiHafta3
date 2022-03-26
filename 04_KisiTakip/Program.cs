using _05_Tipler;
using System;
using System.Collections.Generic;


namespace _04_KisiTakip
{
    class Program
    {
        
        static void Main(string[] args)
        {
            KisiCls k = new KisiCls();
            KisiCls k1 = new KisiCls();
            KisiCls k2 = new KisiCls();

           
            List<KisiCls> kisiler = new List<KisiCls>();
            while (true)
            {
                Console.WriteLine("Yeni Kişi Eklemek için E, yazdırmak için Y, Kişi silmek için S giriniz");
                string islem = Console.ReadLine();
                if (islem == "E")
                {
                    KisiEkle(kisiler);
                }
                else if(islem=="Y")
                {
                    KisileriYazdir(kisiler);
                }
                else if(islem=="S")
                {
                    KisiSil(kisiler);
                }
            }

        }

        static void KisiSil(List<KisiCls> pListe)
        {
            Console.WriteLine("Silinecek id giriniz:");
            int silinecekId = Convert.ToInt32(Console.ReadLine());
            KisiCls silinecekKisi = new KisiCls();
            foreach (KisiCls kisi in pListe)
            {
                if (kisi.Id == silinecekId)
                {
                    Console.WriteLine($"{kisi.Ad} {kisi.Soyad} kişisi silinecek emin misiniz E/H?");
                    string secim = Console.ReadLine();
                    if (secim == "E")
                    {
                        silinecekKisi = kisi;
                    }
                    else
                        return;

                }
            }

            pListe.Remove(silinecekKisi);

        }
        static void KisileriYazdir(List<KisiCls> liste)
        {
            foreach (KisiCls item in liste)
            { //break;continue
                Console.WriteLine($"{item.Id} {item.Ad} {item.Soyad} {item.Yas} {item.Cinsiyet}");
            }

            //for (int i = 0; i < liste.Count; i++)
            //{
            //    Console.WriteLine($"{liste[i].Ad} {liste[i].Soyad} {liste[i].Yas} {liste[i].Cinsiyet}");
            //}
        }
        static void KisiEkle(List<KisiCls> liste)
        {
           
            KisiCls eklenecekKisi = new KisiCls();
           
            Console.WriteLine("Kişinin adını giriniz:");
            eklenecekKisi.Ad = Console.ReadLine();

            Console.WriteLine("Kişinin soyadını giriniz:");
            eklenecekKisi.Soyad = Console.ReadLine();

            Console.WriteLine("Kişinin yaşını giriniz:");
            eklenecekKisi.Yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Erkek için E Kadın için K belirtmek ismeyiyorsa B giriniz:");
            string cinsiyetStr = Console.ReadLine();
            if (cinsiyetStr == "E")
                eklenecekKisi.Cinsiyet = CinsiyetEnum.Erkek;
            else if (cinsiyetStr == "K")
                eklenecekKisi.Cinsiyet = CinsiyetEnum.Kadın;
            else
                eklenecekKisi.Cinsiyet = CinsiyetEnum.BelirtmekIstemiyor;

            liste.Add(eklenecekKisi);
        }

    }
}
