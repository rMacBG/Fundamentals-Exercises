namespace PowerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double total = PowerOfANumber(num, power);
            Console.WriteLine(total);

        }
        public static double PowerOfANumber (double num, double power)
        {
           return Math.Pow(num, power);
        }
    }
}