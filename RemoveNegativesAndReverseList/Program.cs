namespace RemoveNegativesAndReverseList
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] < 0)
                {
                    num.RemoveAt(i);
                    i--;
                }
            }
            num.Reverse();
            if (num.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", num));
            }
        }
    }
}