namespace VowelsCount2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vowelSum();
        }

        public static void vowelSum()
        {
            string word = Console.ReadLine();
            string wordToLower = word.ToLower();
            char[] vowels = {'a', 'e', 'o', 'u', 'i', 'y' };
            int counter = 0;
            for (int i = 0; i < wordToLower.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (wordToLower[i] == vowels[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}