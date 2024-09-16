using System;
using InventorySystem.Domain.productMangment;

namespace InventorySystem.Domain.inventory
{
    public partial class Inventory
    {
        public void removeProduct(string name)
        {
            int index = productExists(name);
            if (index !=-1)
            {
                products.RemoveAt(index);
                Console.WriteLine("Product Removed successfully");
            }
            else
            {
                Console.WriteLine("Product does not exist");
            }
            
        }
        
    }
}