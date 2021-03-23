using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Ayşin Sultan!");

            // type safety - tip güvenliği (strng, int, float) gibi tanımlamalar öncesinde yapılır.
            // String kategoriEtiketi = "Kategoriler"; //metinsel ifadeler için
            // int ogrenciSayisi = 32000;  //tamsayılar için
            // double faizOrani = 1.49;    //ondalıklı sayılar için

            Console.WriteLine("");

            // şart blokları
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Eşittir Oku");
            }

               Console.WriteLine("");
            // if else şart blokları kullanımı
            bool aysinSultanBeniSeviyorMu = false; //false ya da true olması normalde veri kaynağından gelir.

            // tab a çift tıklandığında aşağıdaki if kalıbı açılır.
            if (aysinSultanBeniSeviyorMu == true)
            {
                Console.WriteLine("Ayşin Sultan beni çok seviyormuş, ben de Onu çok seviyorum!!!");
            }
            else
            {
                Console.WriteLine("Ayşin Sultan beni sevmiyormuş ama ben Onu çok seviyorum, beni mutlaka sevmeli");
            }

            Console.WriteLine("");
            Console.WriteLine("for ve foreach döngüleri");
            Console.WriteLine("");

            // array - dizi [] ile gösterilir.
            string[] kurslar = new string[] { "C++", "Java", "Phyton" }; //normalde bu satır string [] kurslar = kurslariGetir(); şeklinde yazılır.
             for (int i = 0; i < kurslar.Length; i++)
             {
                Console.WriteLine(kurslar[i]);
             }

             Console.WriteLine("for bitti");
             Console.WriteLine("");

            foreach (string kurs in kurslar)
            {
              Console.WriteLine(kurs);
            }
             Console.WriteLine("sayfa sonu - footer");


        }
    }
}
