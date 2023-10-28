using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool change = false;
            while (true) 
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                string[] tokens = input.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        integers.Add(numberToAdd);
                        change = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        integers.Remove(numberToRemove);
                        change = true;
                        break;
                    case "RemoveAt":
                        int numberToRemoveAt = int.Parse(tokens[1]);
                        integers.RemoveAt(numberToRemoveAt);
                        change = true;
                        break;
                    case "Insert":
                        int insert = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        integers.Insert(index, insert);
                        change = true;
                        break;
                    case "Contains":
                        int contains = int.Parse(tokens[1]);
                        if (integers.Contains(contains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else 
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> even = new List<int>();
                        for (int i = 0; i < integers.Count; i++)
                        {
                            if (integers[i] % 2 == 0)
                            {
                                even.Add(integers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", even));
                        break;
                    case "PrintOdd":
                        List<int> odd = new List<int>();
                        for (int i = 0; i < integers.Count; i++)
                        {
                            if (integers[i] % 2 != 0)
                            {
                                odd.Add(integers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", odd));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < integers.Count; i++)
                        {
                            sum += integers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string sign = tokens[1];
                        int number = int.Parse(tokens[2]);
                        
                        switch (sign)
                        {
                            case ">":
                                List<int> newList = new List<int>();
                                for (int i = 0; i < integers.Count; i++)
                                {
                                if (integers[i] > number)
                                    {
                                    newList.Add(integers[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", newList));
                                newList.Clear();
                                break;
                            case "<":
                                newList = new List<int>();  
                                for (int i = 0; i < integers.Count; i++)
                                {
                                    if (integers[i] < number)
                                    {
                                        newList.Add(integers[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", newList));
                                newList.Clear();
                                break;
                            case ">=":
                                newList = new List<int>();
                                for (int i = 0; i < integers.Count; i++)
                                {
                                    if (integers[i] >= number)
                                    {
                                        newList.Add(integers[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", newList));
                                newList.Clear();
                                break;
                            case "<=":
                                newList = new List<int>();
                                for (int i = 0; i < integers.Count; i++)
                                {
                                    if (integers[i] <= number)
                                    {
                                        newList.Add(integers[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", newList));
                                break;
                        }
                        break;
                }

            }
            if (change == true)
            {
                Console.WriteLine(string.Join(" ", integers));
            }
            

        }
    }
}