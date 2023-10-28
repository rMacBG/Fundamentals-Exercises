namespace MultiTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            if (s <= 10)
            {
                for (int i = s; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");

                }
            }
            if (s > 10)
            {
                Console.WriteLine($"{n} X {s} = {n * s}");
            }
        }
    }
}