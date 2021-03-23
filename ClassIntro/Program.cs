using System;

namespace ClassIntro
{

    class Program
    {
        static void Main(string[] args)
        {

            //2. tanımlama
            // kurs class ına ait bir kurs1 kursu tanımlandı ve bu değişkenin yeni bir tipte kurs olduğu belirtildi.
            // ve bu kurs1 in özellikleri 1. tanımlama alanında oluşturuldu. kurs1 yaz noktaya bas ve özellikleri seç.
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C++";
            kurs1.Egitmen = "Hayati Özen";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "İbrahim & Hayati";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "İbrahim Kasapoğlu";
            kurs3.IzlenmeOrani = 78;




            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kursData in kurslar)
            {
                Console.WriteLine(kursData.KursAdi + " : " + kursData.Egitmen + " - % " + kursData.IzlenmeOrani);
            }
        }
         //class; string, int gibi veri türü oluşturmak için kullanılır.
        class Kurs
        {
            // 1. tanımlama
            // prop yaz çift tab tuşuna bas ve exceldeki gibi sütunlar tanımlayabilirsin. bunun adı özellik tanımlama. 
            // bu özellik kurs class ına ait bir özelliktir.

            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }





    }



}
