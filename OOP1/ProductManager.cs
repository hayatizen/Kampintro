using System;
using System.Collections.Generic;
using System.Text;

//İçerisinde çeşitli operasyonlar barındıracak.

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        //Ekleme operasyonu için Add oluşturalım ve ne ekleyeceğini belirteceğiz. önce program.cs ye git.
        public void Add(Product product) //void emir kipidir işlemini yapar ve bitirir. Aşağıdak bilgi dışında başka bir bilgiye ihtiyacın yok ise void tanımlnır.
        {

            Console.WriteLine(product.ProductName + " eklendi.");

            //product.ProductName = "Kamera"; 

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        //void ile return arasındaki fark: işlem sonucunda ortaya çıkan formül sonucunu başka bir şeyde daha kullanmak istiyorsanız
        //bunu return ile yaparsın. void sadece yazdırır ve bitirir.

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        }



    }
}
