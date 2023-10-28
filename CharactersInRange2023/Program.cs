namespace CharactersInRange2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharactersInRange(firstChar, secondChar);
        }

        public static void CharactersInRange(char firstChar, char secondChar)
        {
            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);

            for (int i = ++startChar; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }
    }
}