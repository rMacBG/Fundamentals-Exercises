using System.Diagnostics;

namespace ListAndLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            TestLinkedList();
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        const int N = 100000;
        public static void TestList()
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < N; i++)
            {
                list.Add(random.Next(3*N));
            }
            for (int i = 0; i < N; i++)
            {
                list.RemoveAt(0);
            }

        }
        public static void TestLinkedList()
        {
            Random random = new Random();
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < N; i++)
            {
                list.AddLast(random.Next(3 * N));
            }
            for (int i = 0; i < N; i++)
            {
                list.RemoveFirst();
            }
        }
    }
   
   
}