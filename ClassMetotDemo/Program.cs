using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Ayşin";
            musteri1.MusteriSoyadi = "Akman Özen";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Hayati";
            musteri2.MusteriSoyadi = "Özen";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID = " + musteri.Id);
                Console.WriteLine("Müşteri Adı = " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı = " + musteri.MusteriSoyadi);
                Console.WriteLine("--------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle();
            musteriManager.MusteriListele();
            musteriManager.MusteriSil();


        }
            
                    
    }
}


    

