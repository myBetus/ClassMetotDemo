using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "selinay";
            musteri.Soyad = "yılmaz";
            musteri.Urun = "çanta";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "selen";
            musteri2.Soyad = "yılmazer";
            musteri2.Urun = "ayakkabı";
            Musteri[] must = new Musteri[] { musteri, musteri2 };
            MusteriiManager manager = new MusteriiManager();
            Console.WriteLine("lütfen bir seçim yapınız: 1-müşteri ekleme, 2-müşteri listeleme, 3-müşteri silme");
            int secim;
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                  
                    manager.MusteriEkle(musteri);
                    break;
                case 2:

                     Console.WriteLine("müşteriler listeleniyor...");
                    foreach (var musteriler in must)
                    {
                       
                        Console.WriteLine(musteriler.Id);
                        Console.WriteLine(musteriler.Ad);
                        Console.WriteLine(musteriler.Soyad);
                        Console.WriteLine(musteriler.Urun);
                        Console.WriteLine("----------------------------------------------------------");
                    }
                    break;
                case 3:
                    manager.MusteriSilme(musteri2);
                    break;

            }
            Console.ReadKey();
        }
            }
        }
    
