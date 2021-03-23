using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product  //Bu tür özelliklere Entity denir. Burada sadece özellik olur.
    {
        //prop çift tap bas özellikleri oluşturabiliriz.
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //Ekleme silme gibi operasyonlara CRUD operasyonları (Create Read Update Delete)
        //Bu nedenle ProductManager Clası oluştur.

    }
}
