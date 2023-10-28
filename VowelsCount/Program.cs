namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string random = Console.ReadLine();
            VowelsSum(random);

        }
        public static void VowelsSum(string random)
        {
            string toLower = random.ToLower();
            char[] areVowels = {'a', 'e', 'i', 'o', 'u', 'y'};
            byte count = 0;
            for (int i = 0; i < toLower.Length; i++)
            {
                for (int j = 0; j < areVowels.Length; j++)
                {
                    if (toLower[i] == areVowels[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}