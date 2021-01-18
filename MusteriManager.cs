using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        public bool musteriEkle(Musteri m)
        {
            Console.WriteLine("{0} {1} Adlı kullanıcı sisteme eklendi.",m.firstName,m.lastName);
            musteriler.Add(m);
            return true;
        }

        public List<Musteri> musteriList()
        {
            return musteriler;
        }

        public bool musteriSil(Musteri m)
        {
            // müşteriyi silme işlemi yapılmaktadır.
            musteriler.Remove(m);
            return true;
        }

        public bool musteriGuncelle(Musteri m)
        {
            /*
             * bulunan müşteriyi silip yeniden ekleme işlemi yapılmaktadır.
             */
            var musteriID = musteriler.Find(all => all.id == m.id ); 
            musteriler.Remove(musteriID);
            musteriler.Add(m);
            return true;
        }
    }
}
