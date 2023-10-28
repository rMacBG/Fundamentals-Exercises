using System.Linq.Expressions;

namespace ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] args = commands.Split();
                if (args[0] == "Delete")
                {
                    int element = int.Parse(args[1]);
                    list.RemoveAll(x => x == element);
                }
                else if (args[0] == "Insert")
                {
                    int element = int.Parse(args[1]);
                    int index = int.Parse(args[2]);
                    list.Insert(index, element);
                    
                }

               commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}