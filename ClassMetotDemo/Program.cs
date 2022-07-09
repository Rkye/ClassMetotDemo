using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
     class Program
    {
         static void Main(string[] args)
        {
          
            Musteri musteri1 = new Musteri();
            musteri1.BankaId = 12345;
            musteri1.Ad = "Cahide";
            musteri1.Soyad = "Altın";
            musteri1.TcNo = "1598742312";

            Musteri musteri2 = new Musteri();
            musteri2.BankaId = 12346;
            musteri2.Ad = "Nahide";
            musteri2.Soyad = "Gümüş";
            musteri2.TcNo = "15981562312";

            Musteri musteri3 = new Musteri();
            musteri3.BankaId = 12347;
            musteri3.Ad = "Vahide";
            musteri3.Soyad = "Bakır";
            musteri3.TcNo = "2658742312";

            Musteri musteri4 = new Musteri();
            musteri4.BankaId = 12348;
            musteri4.Ad = "Vahit";
            musteri4.Soyad = "Bakır";
            musteri4.TcNo = "2658742989";

           

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriListeleme();
            Console.WriteLine("********1. listeleme sonu********");
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListeleme();
            Console.WriteLine("********2. listeleme sonu********");
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriListeleme();
            Console.WriteLine("********3. listeleme sonu********");



        }
    }
}
