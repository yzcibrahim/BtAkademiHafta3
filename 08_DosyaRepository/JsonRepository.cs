using _05_Tipler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _08_DosyaRepository
{
    public class JsonRepository
    {
        public List<KisiCls> Get()
        {
            string kisilerJson = File.ReadAllText("Kisiler.json");
            return JsonSerializer.Deserialize<List<KisiCls>>(kisilerJson);
        }

        public KisiCls GetById(int id)
        {
            List<KisiCls> mevcut = Get();
            return mevcut.FirstOrDefault(c => c.Id == id);
        }

        public void Add(KisiCls kisi)
        {
            List<KisiCls> mevcut = Get();
            mevcut.Add(kisi);

            Save(mevcut);
        }

        public void Delete(int id)
        {
            List<KisiCls> mevcut = Get();
            mevcut = mevcut.Where(c => c.Id != id).ToList();

            Save(mevcut);
        }

        public void Update(KisiCls kisi)
        {
            List<KisiCls> mevcut = Get();
            var updateEdilecek = mevcut.FirstOrDefault(c => c.Id == kisi.Id);
            if (updateEdilecek != null)
            {
                updateEdilecek.Ad = kisi.Ad;
                updateEdilecek.Soyad = kisi.Soyad;
                updateEdilecek.Yas = kisi.Yas;
                updateEdilecek.Cinsiyet = kisi.Cinsiyet;
                Save(mevcut);
            }

        }


        public void Save(List<KisiCls> mevcut)
        {
            string kisilerJson = JsonSerializer.Serialize(mevcut);
            File.WriteAllText("Kisiler.json", kisilerJson);
        }

    }
}
