using System;
using InventorySystem.Domain.General;

namespace InventorySystem.Domain.productMangment
{
    public class Product
    {
        private int quntityInStock = 0;
        public string Name { get; set; } = string.Empty;
        public int Quantity
        {
            get { return quntityInStock; }
            set { quntityInStock = value; }
        }
        public Price Price { get; set; }
        public Product(int quntity):this(quntity,"")
        {
        }
        public Product(int quntity,string name)
        {
            Quantity = quntity;
            Name = name;
        }
        public Product( string name,Price price,int quntity)
        {
            Quantity = quntity;
            Name = name;
            Price = price;
        }

        public void ViewProduct()
        {
            Console.WriteLine($"\n{Name} , is in stock: {quntityInStock} , its price: {Price}");
        }
    }
   
}