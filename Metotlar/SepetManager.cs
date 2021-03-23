using System;
using System.Collections.Generic;
using System.Text;

// manager, service, dal, data access, controler gibi ifadeler operasyon tutuyor demektir. 
namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax yazım şekilleri
        //pyhton da yazılan def burada public void olarak yazıldı. ortak kod tanımlama
        //aşağıda Ekle fonksiyonu tanımlandı.
        // buradaki gibi normal bir parantez var ise burada bir metot çalışır (jave ve c# için geçerli).
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        //Aşağıdaki sadece fonksiyon ama herşey manuel yazılı. 
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
