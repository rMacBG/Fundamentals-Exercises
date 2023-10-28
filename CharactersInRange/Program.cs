namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            CharsInRange(input1, input2);
        }

        private static void CharsInRange(char input1, char input2)
        {
            int firstChar =  Math.Min(input1, input2);
            int secondChar = Math.Max(input1, input2);

            for (int i = ++firstChar; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}