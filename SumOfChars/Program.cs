namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sum = sum + character;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}