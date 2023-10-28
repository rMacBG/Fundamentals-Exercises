namespace Town_Info
{
    public class Program
    {
        static void Main(string[] args)
        {
           string townName = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            int sqrKm = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {population} and area {sqrKm} square km.");
        }
    }
}