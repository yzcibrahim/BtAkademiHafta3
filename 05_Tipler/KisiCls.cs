using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Tipler
{
    public class KisiCls
    {
        static int count = 0;
        public int Id { get; set; } = 0;
        public KisiCls()
        {
            Id = count + 1;
            count++;
        }
        public KisiCls(string ad, string soyad, CinsiyetEnum cinsiyet,int yas )
        {
            Id = count + 1;
            count++;
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
            Yas = yas;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }
        public int Yas { get; set; }

        public string Yazdir()
        {
            return $"{Id} {Ad} {Soyad} {Yas} {Cinsiyet}";
        }

    }

    public enum CinsiyetEnum
    {
        Kadın,
        Erkek,
        BelirtmekIstemiyor
    }
}
