using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ EKLENDİ");
            Console.WriteLine("EKLENEN KİŞİNİN ADI, SOYADI, BORCU :" + musteri.Ad + " " + musteri.SoyAd + " "+" "+musteri.Borc+" ");
                
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ SİLİNDİ");
            Console.WriteLine("SİLİNEN KİŞİNİN ADI VE SOYADI, BORCU : " + musteri.Ad +" "+ musteri.SoyAd+" "+musteri.Borc+" ");
        }
        public void MusteriListeleme(Musteri[] musteri)
        {
            Console.WriteLine("KİŞİLER LİSTELENİYOR...");
            foreach (var musteriler in musteri)
            {
             
                Console.WriteLine(musteriler.Id + " " + musteriler.Ad + " " + musteriler.SoyAd + " " + musteriler.Memleket+" "+musteriler.Borc);
            }
        }
    }
}
