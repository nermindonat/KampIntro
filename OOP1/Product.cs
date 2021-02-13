using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {           //snippet
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }  //ürün fiyat
        public int UnitsInStock { get; set; }   //stok adedi
    }
}
