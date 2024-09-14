using System;

namespace InventorySystem.Domain.inventory
{
    public partial class Inventory
    {
        public void ViewProducts()
        {
                if (products.Count!= 0)
                {
                    for (int i=0;i<products.Count;i++)
                        products[i].ViewProduct();
                }
                else
                {
                    Console.WriteLine("There are no inventory products.");
                }
            
        }
    }
}