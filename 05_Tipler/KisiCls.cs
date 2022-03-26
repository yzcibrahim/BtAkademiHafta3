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
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }
        public int Yas { get; set; }

    }

    public enum CinsiyetEnum
    {
        Kadın = 0,
        Erkek = 1,
        BelirtmekIstemiyor = 2
    }
}
