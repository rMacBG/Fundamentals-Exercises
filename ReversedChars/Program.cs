using System.Threading.Channels;

namespace ReversedChars
{
    public class Program
    {
        static void Main(string[] args)
        {

           var char1 = Console.ReadLine();
           var char2 = Console.ReadLine();
           var char3 = Console.ReadLine();

            Console.WriteLine($"{char3} {char2} {char1}");


        }
    }
}