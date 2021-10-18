using System;
using System.Globalization;
using System.Collections.Generic;
using Restricoes.Entities;
using Restricoes.Services;

namespace Restricoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vector = Console.ReadLine().Split(',');
                double price = double.Parse(vector[1], CultureInfo.InvariantCulture);

                list.Add(new Product(vector[0], price));
            }

            CalculationService calculations = new CalculationService();

            Product p = calculations.Max(list);

            Console.Write("Most Expensive: ");
            Console.Write(p);
        }
    }
}
