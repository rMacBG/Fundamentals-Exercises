namespace SortedListWithAdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
          const int N = 10;
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter a number: ");
                int x = int.Parse(Console.ReadLine());
                var iter = list.First;
                while (iter != null && iter.Value < x)
                {
                    iter = iter.Next;
                }
                if (iter == null)
                {
                    list.AddLast(x);
                }
                else
                {
                    list.AddBefore(iter, x);
                }
                Console.WriteLine(string.Join(" ", list));

            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}