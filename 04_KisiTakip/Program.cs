using _05_Tipler;
using _07_CommonOps;
using _08_DosyaRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace _04_KisiTakip
{
    class Program
    {
       static TxtRepository _repository;
        static void Main(string[] args)
        {
            _repository = new TxtRepository();

            List<KisiCls> kisiler = new List<KisiCls>();
            kisiler = _repository.KisileriOku();

           string seriStr= JsonSerializer.Serialize(kisiler);

            var liste = JsonSerializer.Deserialize<List<KisiCls>>(seriStr);

            while (true)
            {
                Console.WriteLine(@"Yeni Kişi Eklemek için E, yazdırmak için Y, filtreleme yapamk için F, Kişi silmek için S, " +
                    "Yaş ve cinsiyete göre filtrelemek için YC giriniz");
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
                    kisiler= KisiSil(kisiler);
                }
                else if (islem == "F")
                {
                    Filtrele(kisiler);
                }
                else if (islem == "YC")
                {
                    FiltreleYC(kisiler);
                }
            }

        }

        static void FiltreleYC(List<KisiCls> liste)
        {

            //yaşı 23 olan erkekler
            //var filtrelenmisListe = liste.Where(c => c.Cinsiyet == CinsiyetEnum.Erkek && c.Yas == 23).ToList();
            //KisileriYazdir(filtrelenmisListe);

            //23 yaşında kaç kişi var
            var kacKisiVar = liste.Count(c => c.Yas == 23);
            Console.WriteLine(kacKisiVar);

            //adı E ile başlayanlar
            var baslayanlar = liste.Where(c => c.Ad.ToUpper().StartsWith("E")).ToList();
            KisileriYazdir(baslayanlar);

            //kaç farklı isim var
            var Isimler = liste.Select(c => c.Ad).ToList();
            var uniqisimler = liste.Select(c => c.Ad).Distinct().ToList();


            List<string> isimler1 = liste.Where(c => c.Yas > 30).Select(x => x.Ad).ToList();

            List<string> isimler = (from k in liste
                                    where k.Yas > 30
                                    select k.Ad).ToList();
                                 


            #region first single default farkları

            //var kisiF = liste.First(c=>c.Yas==30);
            //var kisiFd = liste.FirstOrDefault(c => c.Yas == 99);

            //var kisiS = liste.Single(c => c.Yas == 30);
            //var kisiSd = liste.SingleOrDefault(c => c.Yas == 99);
            #endregion
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

        static List<KisiCls> KisiSil(List<KisiCls> pListe)
        {
            //Console.WriteLine("Silinecek id giriniz:");
            //int silinecekId = Convert.ToInt32(Console.ReadLine());
            int silinecekId = Operations.IntOku("Silinecek Id giriniz");
            KisiCls silinecekKisi = new KisiCls();

            #region
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
            // silinecekKisi = pListe.Where(c => c.Id == silinecekId).First();
            //silinecekKisi = pListe.First(x=>x.Id== silinecekId);
            //pListe.Remove(silinecekKisi);
            #endregion
            pListe = pListe.Where(c => c.Id != silinecekId).ToList();

            _repository.DosyayaKaydet(pListe);
            
            return pListe;

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
            #region alternate
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
            #endregion
            liste.Add(eklenecekKisi);
            
            _repository.DosyayaKaydet(liste);

        }


    }
}
