using ExerFixHerPolimorf.Entities;
using System;
using System.Collections.Generic;

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
                Console.Write("Common, used or imported (c/u/i)? ");
                Console.Write("Name: ");
                Console.Write("Price");
                Console.Write("Customs fee: ");
                Console.Write("Manufacture date (DD/MM/YYYY): ");
            }
            
        }
    }
}
