using System;

namespace OOP1
{   //OOP projesi çalışmasıdır. 
    // Product clası oluştur.
    // ProductManager clası oluştur.
    //intentioanal programming : önce ihtiyaçlar kodlanır sonra doldurulur. niyet güdümlü programlama
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa"; //normalde burası bu şekilde yazılır. tbxProductName.Text; bu kullanıcının oraya girdiği değer oluyor.
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //yukaridakini aşağıdaki gibi de oluşturabiliriz.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName ="Kalem", UnitPrice = 35 };

            //PascalCase: İlk kelimelerin ilk harfleri büyük yazılır. ( Classları belirtir. )
            //camelCase: İlk kelimelerin ilk harfleri küçük sonraki kelimenin ilk harfi büyük yazılır. (Classa ait değişken ismi)
            //case sensitive küçük harf büyük harf duyarlı.
            //referans tiplerin heapte oluşabilmesi için new lenmesi gerekir.
            //          Stack             =         Heap
            ProductManager productManager = new ProductManager(); 
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            ////void sonucu
            //productManager.Topla2(3, 6);
            
            ////return sonucu
            //int toplamaSonucu = productManager.Topla(3, 6);

            //Console.WriteLine(toplamaSonucu*2);

            //int, double, bool, ... değer tiplerdir. (atamalar değer üzerinden olur ve bağlantı kopar. sayının sadece değerini yolluyor.)
            //diziler, class, abstract class, interface ... referans tiptir.
            //ref out keywordler öğrenmeli.

            //dizaynpattern, solid (oop)

        }
    }
}
