using System;
using InventorySystem.Domain.General;
using InventorySystem.Domain.inventory;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            int choice;
           
            do
            {
                Console.WriteLine("Please enter a choice #");
                Console.WriteLine(" 1.add a product"
                                  +"\n 2.view all Products"
                                  +"\n 3.Edit a product"
                                  + "\n 4.Delete a product"
                                  +"\n 5.Search for a product" +
                                  "\n 6.Exit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the product name");
                    string name = Console.ReadLine();
                    
                    Console.WriteLine("Enter the product quantity");
                    int qun = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Enter the product price include the item price and the curreny");
                    double p = double.Parse(Console.ReadLine());
                    Currency c = (Currency)Enum.Parse(typeof(Currency), Console.ReadLine());
                    
                     inventory.AddProduct(name,p,c,qun);

                }
                else if (choice==2)
                {
                    inventory.ViewProducts();
                }
                else if (choice==3)
                {
                    
                    
                }
                else if (choice==4)
                {
                    Console.WriteLine("Enter the product name to delete the product");
                    string name=Console.ReadLine();
                    inventory.removeProduct(name);

                }
                else if (choice==5)

                {
                    Console.WriteLine("Enter the product name");
                    string name = Console.ReadLine();
                    inventory.search(name);
                }
                
            } while ( choice!= 6);
        }
    }
}