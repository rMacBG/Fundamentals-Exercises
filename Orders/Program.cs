namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            ProductCalculations(product, quantity);


        }
        private static void ProductCalculations(string product, int quantity)
        {
            switch (product) 
            {
                case "coffee":
                    Console.WriteLine($"{quantity * 1.5:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity * 1.0:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity *1.4:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2.0:f2}");
                    break;
            }
        }
    }
}