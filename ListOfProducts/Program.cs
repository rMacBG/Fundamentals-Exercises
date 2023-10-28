﻿namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine(); 
                products.Add(current);
            }
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}