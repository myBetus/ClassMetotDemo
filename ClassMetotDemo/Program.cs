using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "BETÜL";
            musteri1.SoyAd = "AVCI";
            musteri1.Memleket = "AĞRI";
            musteri1.Borc = 0;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "ELİF";
            musteri2.SoyAd = "KARSU";
            musteri2.Memleket = "BOLU";
            musteri2.Borc = 1000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "ZEYNEP";
            musteri3.SoyAd = "YILDIRIM";
            musteri3.Memleket = "İSTANBUL";
            musteri3.Borc = 20000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            //foreach (var musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.SoyAd + " " + musteri.Memleket+" "+musteri.Borc);
            //}

            MusteriManager musteri = new MusteriManager();
            musteri.MusteriEkleme(musteri1);
            musteri.MusteriSilme(musteri2);
            musteri.MusteriListeleme(musteriler);
        }
        
    }
}
