using _05_Tipler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08_DosyaRepository
{
    public class TxtRepository
    {
        public List<KisiCls> KisileriOku()
        {
            List<KisiCls> kisiler = new List<KisiCls>();
            string kisilerStr = File.ReadAllText("Kisiler.txt");
            var kisiDizi = kisilerStr.Split("\n");

            foreach (var kisiSatir in kisiDizi)
            {
                if (String.IsNullOrWhiteSpace(kisiSatir))
                    break;
                string[] kisiAlanlari = kisiSatir.Split("@");
                KisiCls kisi = new KisiCls(kisiAlanlari[1], kisiAlanlari[2], CinsiyetEnum.BelirtmekIstemiyor, Convert.ToInt32(kisiAlanlari[3]));
                kisi.Cinsiyet = kisiAlanlari[4] == "Erkek" ? CinsiyetEnum.Erkek
                                : kisiAlanlari[4] == "Kadın" ? CinsiyetEnum.Kadın
                                : CinsiyetEnum.BelirtmekIstemiyor;
                kisi.Id = Convert.ToInt32(kisiAlanlari[0]);
                kisiler.Add(kisi);
                #region Alternate
                //KisiCls kisi = new KisiCls();
                //string[] alanlarDizi = kisiSatir.Split("@");
                //kisi.Id = Convert.ToInt32(alanlarDizi[0]);
                //kisi.Ad = alanlarDizi[1];
                //kisi.Soyad = alanlarDizi[2];
                //kisi.Yas = Convert.ToInt32(alanlarDizi[3]);
                //if (alanlarDizi[4] == "Erkek")
                //{
                //    kisi.Cinsiyet = CinsiyetEnum.Erkek;
                //}
                //else if (alanlarDizi[4] == "Kadın")
                //{
                //    kisi.Cinsiyet = CinsiyetEnum.Kadın;
                //}
                //else
                //    kisi.Cinsiyet = CinsiyetEnum.BelirtmekIstemiyor;

                //kisiler.Add(kisi);
                #endregion
            }

            KisiCls.count = kisiler.Max(c => c.Id);
            return kisiler;
        }

        public void DosyayaKaydet(List<KisiCls> liste)
        {
            string dosyaIcerigi = "";
            foreach (var item in liste)
            {
                //  dosyaIcerigi += item.Id +"@"+ item.Ad + "@" + item.Soyad + "@" + item.Yas + "@" + item.Cinsiyet+"\n";
                dosyaIcerigi += $"{item.Id}@{item.Ad}@{item.Soyad}@{item.Yas}@{item.Cinsiyet}\n";
            }
            File.WriteAllText("Kisiler.txt", dosyaIcerigi);
        }

    }
}
