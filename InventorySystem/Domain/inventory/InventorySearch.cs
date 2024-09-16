using System;

namespace InventorySystem.Domain.inventory
{
    public partial class Inventory
    {
        public void search(string name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == name)
                {
                    Console.WriteLine("the product exist");
                    products[i].ViewProduct();
                    return;
                }
               
            }
           Console.WriteLine("the product dosen't exist");
        }
        public int productExists(string name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == name)
                    return i;
            }
            return -1;
        }
    }
}