namespace Randomize_Words
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var words = Console.ReadLine()
              .Split()
              .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                var newIndex = rnd.Next(0, words.Length);

                var a = words[newIndex];
                var b = words[i];
                words[newIndex] = b;
                words[i] = a;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}