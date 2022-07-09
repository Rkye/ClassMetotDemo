using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        List<Musteri> musteriler = new List<Musteri> { };

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşteri eklendi.");
            musteriler.Add(musteri);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli " + musteri.BankaId + 
                " nolu ID ye sahip müşteri silindi.");
            musteriler.Remove(musteri);
        }

        
        
        public void MusteriListeleme()
        {
            
            foreach (var musterler in musteriler)
            {
                Console.WriteLine(musterler.BankaId + " : " + musterler.Ad + " " + musterler.Soyad + " " + musterler.TcNo);
            }
        }
    }
}
