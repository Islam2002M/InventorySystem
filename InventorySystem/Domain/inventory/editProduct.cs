using System;
using InventorySystem.Domain.General;
using InventorySystem.Domain.productMangment;

namespace InventorySystem.Domain.inventory
{
    public partial class Inventory
    {
        public void EditProduct(string productName)
        {
            int index = productExists(productName);
            if (index != -1)
            {
                Console.WriteLine("What do you want to edit?");
                int c;
                Console.WriteLine(" 1.Product Name"
                                  + "\n 2.Products Quantity"
                                  + "\n 3.Product price");
                c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("Enter a new name for this product");
                    string newName = Console.ReadLine();
                    products[index].Name = newName;
                    Console.WriteLine("Product name edited successfully");
                }
                else if (c == 2)
                {
                    Console.WriteLine("Enter a new quantity for this product");
                    int newQuna = int.Parse(Console.ReadLine());
                    products[index].Quantity = newQuna;
                    Console.WriteLine("Product quantity edited successfully");

                }
                else if (c == 3)
                {
                    Console.WriteLine("Enter a new price include the item price and the curreny for this product");
                    double p = double.Parse(Console.ReadLine());
                    Currency cc = (Currency)Enum.Parse(typeof(Currency), Console.ReadLine());
                    Price price = new Price(p, cc);
                    products[index].Price = price;
                    Console.WriteLine("Product price edited successfully");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else
            {
                Console.WriteLine("Product does not exist");
            }
        }
    }
}