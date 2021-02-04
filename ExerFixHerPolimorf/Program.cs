using ExerFixHerPolimorf.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerFixHerPolimorf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = Console.ReadLine()[0];
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'u' || type == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Product prod = new UsedProduct(name, price, manufactureDate);
                    list.Add(prod);
                }
                else if (type == 'i' || type == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product prod = new ImportedProduct(name, price, customsFee);
                    list.Add(prod);
                }
                else
                {
                    Product prod = new Product(name, price);
                    list.Add(prod);
                }

                
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
