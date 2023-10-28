namespace CenturiesToMinutes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int years = n * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{n} centuries = {years} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");

        }
    }
}