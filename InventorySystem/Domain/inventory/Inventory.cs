using System;
using System.Collections.Generic;
using InventorySystem.Domain.General;
using InventorySystem.Domain.productMangment;

namespace InventorySystem.Domain.inventory
{
    public class Inventory
    {
        private List <Product> products = new List<Product>();

        public void AddProduct(string name, double price, Currency currency, int quantity)
        {   Price p=new Price(price,currency);
            Product product=new Product(name,p,quantity);
            products.Add(product);
            Console.WriteLine("Product added successfully");
        }
 
    }
}