namespace MetersToKilometers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double km = n / 1000.0;
            Console.WriteLine($"{km:f2}");
        }
    }
}