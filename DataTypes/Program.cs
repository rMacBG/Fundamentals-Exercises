namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                IntInput();
            }
            else if (input == "real")
            {
                RealInput();
            }
            else if (input == "string")
            {
                StringInput();
            }
        }

        private static void StringInput()
        {
            string input = Console.ReadLine();
            Console.WriteLine($"${input}$");

        }

        private static void RealInput()
        {
            double input = double.Parse(Console.ReadLine());
            double total = input * 1.5;
            Console.WriteLine($"{total:F2}");
        }

        private static void IntInput()
        {
            int input = int.Parse(Console.ReadLine());
            int total = input * 2;
            Console.WriteLine($"{total}");
        }
    }
}