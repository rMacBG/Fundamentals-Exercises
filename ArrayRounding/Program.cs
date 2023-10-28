namespace ArrayRounding
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (double num in arr)
            {
                Console.WriteLine($"{num} => {Math.Round(num, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}