using System;
using System.Reflection.Metadata.Ecma335;

namespace ExamTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(',')
                .ToList();
            int blacklistedNames = 0;
            int lostNames = 0;
            string input = Console.ReadLine();
            while (input != "Report")
            {

                string[] arguments = input.Split();
                
                if (arguments[0] == "Blacklist")
                {
                    string name = arguments[1];
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names.Exists(x => x == name))
                        {
                            names[i] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");
                            blacklistedNames++;
                            break;
                        }
                        if (!names.Contains(name))
                        {
                            Console.WriteLine($"{name} was not found");
                            
                        }
                    }
                    
                }
                else if (arguments[0] == "Error")
                {
                    int index = int.Parse(arguments[1]);
                    if (index >= 0 && index <= names.Count)
                    {
                        string lostName = "Lost";
                        if (names[index] == "Blacklisted" || names[index] == "Lost")
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine($"{names[index]} was lost due to an error.");
                            names[index] = $"{lostName}";
                            lostNames++;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else if (arguments[0] == "Change")
                {
                    string changedName = arguments[2];
                    int index = int.Parse(arguments[1]);
                    if (index < 0 || index >= names.Count)
                    {
                        Console.WriteLine($"{names[index]} changed his username to {changedName}.");
                        names[index] = $"{changedName}";
                    }
                    else
                    {
                        
                        return;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: {blacklistedNames}");
            Console.WriteLine($"Lost names: {lostNames}");
            Console.WriteLine(string.Join("", names));
            //foreach (var item in names)
            //{
            //    Console.Write($"{item} ");
            //}
        }
    }
}