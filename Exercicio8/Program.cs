using Exercicio8.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine("Common, used or imported (c/u/i)");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine($"Product {i} data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                if(ch == 'u')
                {
                    Console.WriteLine("Manufacture date: ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                if(ch == 'i')
                {
                    Console.WriteLine("Customs Fee");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach(Product prod in list){
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
