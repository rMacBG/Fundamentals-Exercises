namespace ConcatNames
{
    public class Program
    {
        static void Main(string[] args)
        {
           string FstName = Console.ReadLine();
            string SndName = Console.ReadLine();
            string Delimeter = Console.ReadLine();

            Console.WriteLine($"{FstName}{Delimeter}{SndName}");
        }
    }
}