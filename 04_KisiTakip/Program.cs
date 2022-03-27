using _05_Tipler;
using _07_CommonOps;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _04_KisiTakip
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            List<KisiCls> kisiler = new List<KisiCls>();
            while (true)
            {
                Console.WriteLine("Yeni Kişi Eklemek için E, yazdırmak için Y, filtreleme yapamk için F, Kişi silmek için S giriniz");
                string islem = Console.ReadLine();
                if (islem.ToUpper() == "E")
                {
                    KisiEkle(kisiler);
                }
                else if (islem == "Y")
                {
                    KisileriYazdir(kisiler);
                }
                else if (islem == "S")
                {
                    KisiSil(kisiler);
                }
                else if (islem == "F")
                {
                    Filtrele(kisiler);
                }
            }

        }

        static void Filtrele(List<KisiCls> liste)
        {
            Console.WriteLine("Aranacak kelimeyi giriniz:");
            string aranacakKelime = Console.ReadLine();
            List<KisiCls> filtrelenmisListe = new List<KisiCls>();
            filtrelenmisListe = liste.Where(c => c.Ad == aranacakKelime || c.Soyad==aranacakKelime).ToList();
            //foreach (var item in liste)
            //{
            //    if (item.Ad == aranacakKelime || item.Soyad == aranacakKelime)
            //    {
            //        filtrelenmisListe.Add(item);
            //    }
            //}

            KisileriYazdir(filtrelenmisListe);

        }

        static void KisiSil(List<KisiCls> pListe)
        {
            //Console.WriteLine("Silinecek id giriniz:");
            //int silinecekId = Convert.ToInt32(Console.ReadLine());
            int silinecekId = Operations.IntOku("Silinecek Id giriniz");
            KisiCls silinecekKisi = new KisiCls();

            // silinecekKisi = pListe.Where(c => c.Id == silinecekId).First();
            silinecekKisi = pListe.First(x=>x.Id== silinecekId);
            //foreach (KisiCls kisi in pListe)
            //{
            //    if (kisi.Id == silinecekId)
            //    {
            //        Console.WriteLine($"{kisi.Ad} {kisi.Soyad} kişisi silinecek emin misiniz E/H?");
            //        string secim = Console.ReadLine();
            //        if (secim == "E")
            //        {
            //            silinecekKisi = kisi;
            //            break;
            //        }
            //        else
            //            return;

            //    }
            //}

            pListe.Remove(silinecekKisi);

        }
        static void KisileriYazdir(List<KisiCls> liste)
        {
            foreach (var item in liste)
            { //break;continue
              //   Console.WriteLine($"{item.Id} {item.Ad} {item.Soyad} {item.Yas} {item.Cinsiyet}");
                Console.WriteLine(item.Yazdir());
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

            //Console.WriteLine("Kişinin yaşını giriniz:");
            //eklenecekKisi.Yas = Convert.ToInt32(Console.ReadLine());
            eklenecekKisi.Yas = Operations.IntOku("Kişinin yaşını giriniz:");

            Console.WriteLine("Erkek için E Kadın için K belirtmek ismeyiyorsa B giriniz:");
            string cinsiyetStr = Console.ReadLine();
            if (cinsiyetStr == "E")
                eklenecekKisi.Cinsiyet = CinsiyetEnum.Erkek;
            else if (cinsiyetStr == "K")
                eklenecekKisi.Cinsiyet = CinsiyetEnum.Kadın;
            else
                eklenecekKisi.Cinsiyet = CinsiyetEnum.BelirtmekIstemiyor;
            //Console.WriteLine("Kişinin Adını Soyadını yaşını ve cinsiyetini aralarda boşluk olarak giriniz. Erkek için E kadın için K");
            //string girilenDeger = Console.ReadLine();
            //string[] degerlerDizi = girilenDeger.Split(" ");
            //CinsiyetEnum cnsEnum=CinsiyetEnum.BelirtmekIstemiyor;
            //if(degerlerDizi[3]=="E")
            //{
            //    cnsEnum = CinsiyetEnum.Erkek;
            //}
            //else if(degerlerDizi[3] == "K")
            //{
            //    cnsEnum = CinsiyetEnum.Kadın;
            //}

            //int yas = Convert.ToInt32(degerlerDizi[2]);
            //KisiCls eklenecekKisi = new KisiCls(degerlerDizi[0], degerlerDizi[1], cnsEnum, yas);

            liste.Add(eklenecekKisi);
        }

    }
}
