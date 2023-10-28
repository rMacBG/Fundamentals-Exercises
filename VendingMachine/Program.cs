namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string line = Console.ReadLine();
            double moneyTracker = 0;
            while (line != "Start")
            {
                double moneyInput = double.Parse(line);
                if (moneyInput == 0.1)
                {
                    moneyTracker += 0.1;
                }
                else if (moneyInput == 0.2)
                {
                    moneyTracker += 0.2;
                }
                else if (moneyInput == 0.5)
                {
                    moneyTracker += 0.5;
                }
                else if (moneyInput == 1)
                {
                    moneyTracker += 1;
                }
                else if(moneyInput == 2)
                {
                    moneyTracker += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {moneyInput}");
                }
               line = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product == "Nuts" && moneyTracker >= 2)
                {

                    moneyTracker -= 2;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (product == "Water" && moneyTracker >= 0.7)
                {
                    moneyTracker -= 0.7;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (product == "Crisps" && moneyTracker >= 1.5)
                {
                    moneyTracker -= 1.5;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (product == "Soda" && moneyTracker >= 0.8)
                {
                    moneyTracker -= 0.8;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (product == "Coke" && moneyTracker >= 1.0)
                {
                    moneyTracker -= 1.0;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Invalid product");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {moneyTracker:f2}");
        }
    }
}