using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 = ?? - 30
            //değer tiplerde değer atandığı için
            //sayı1 = sayı2 olduğundan yani
            //   10 = 30 sayı1 artık 30 olduğundan en başta daha sonrasında sayı2 ye ne verirsen ver kopar ve sadece ilk baştaki değeri alır.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] = ? - 999

            //int, decimal, float, double, bool (1,0,true,false) = Değer tipler (sayısal veri tipleri)
            //array, class, interface = referans tipler
            //Bellekte stack (değer tipte olanlar burada tanımlanır.) ve heap (referans tipler burada tanımlanır) diye alan var.
            //değer tiplerde değeri atar, referans tiplerde referansı atar.

            // ilk başta sayilar1 in ve sayilar 2 nin heapteki karşılıkları oluşturulur. 
            //      stack                  heap
            //101 sayilar1 ------> 101 [ 10, 20, 30 ]
            //102 sayilar2 ------> 102 [ 100, 200, 300 ]

            //Daha sonra sayilar1 = sayilar2 olduğunda bu sefer sayılar1 102 deki referansı alır. ve artık sayilar2 ne ise onun değerine sahip olur.
            //102 sayilar1 ------> 102 [ 999, 200, 300 ]
            //102 sayilar2 ------> 102 [ 999, 200, 300 ]

        }
    }
}
