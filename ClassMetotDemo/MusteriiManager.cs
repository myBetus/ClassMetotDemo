using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriiManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+ musteri.Ad+" "+ musteri.Soyad+" " + musteri.Urun+ " /Müşteri eklendi");
        }
        public void MusteriListele()
        {
            Console.WriteLine("müşteriler listleniyor");
        }
        public void MusteriSilme( Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" "+  musteri.Ad +" "+ musteri.Soyad +" " + musteri.Urun + " /Müşteri silindi");
        }
    }
}
