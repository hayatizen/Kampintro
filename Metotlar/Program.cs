using System;

namespace Metotlar
{
    // metotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır. Clean Code - Best Practice (Doğru uygulama teknikleri)
    // Class ların ilk harfleri büyük yazılır.
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            // Class lar aşağıdaki şekilde daha basit tanımlanır.

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            
            foreach (Urun urun in urunler) //sondaki urunler üstteki array dizisidir. solundaki urun dönen ifadelere verilen takma addır. En soldaki Urun ise class tır yani veri tipidir (type - safe -- tip güvenli) yerine var da yazılabilir onun tipini yakalar. // foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");

            }

            //cw yaz 2 tap yapın console.writline yazar
            Console.WriteLine("-------------------Metotlar------------------");

            //instance - class örneği oluşturma 
            //Metotlar bir çok sayfada kullanmak üzere ortak kod oluşturma sağlarlar. aşağıdaki sepetManager.Ekle(); ile farklı sayfalar temsil edilmiştir.
           //encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //Ekle2 fonksiyonunun clas oluşturmadan yazımı aşağıdaki şekildedir. Bu şekilde yazmak hatalıdır. üstteki gibi yaz.

            sepetManager.Ekle2("Armut", "Yeşil", 12, 8);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 7);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}
