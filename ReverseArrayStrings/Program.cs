namespace ReverseArrayStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine()
                .Split().ToArray();

            Console.WriteLine(string.Join(" ", str.Reverse()));
        }
    }
}