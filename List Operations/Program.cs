namespace List_Operations
{
    internal class Program
    {
        static void Main()
        {
            List<int> integers= Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string commands = Console.ReadLine();
            while (commands != "End")
            {
                string[] arguments = commands.Split();
                commands = Console.ReadLine();

                if (arguments[0] == "Add")
                {
                    int num = int.Parse(arguments[1]);
                    integers.Add(num);
                }
                else if (arguments[0] == "Insert")
                {
                    int num = int.Parse(arguments[1]);
                    int index = int.Parse(arguments[2]);
                    if (IsNotValidIndex(index, integers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.Insert(index, num);
                    }
                }
                else if (arguments[0] == "Remove")
                {
                    int num = int.Parse(arguments[1]);
                    if (IsNotValidIndex(num, integers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.Remove(num);
                    }
                        
                    
                }
                else if (arguments[0] == "Shift")
                {
                    int counter = int.Parse(arguments[2]);
                    string direction = arguments[1];
                    counter %= counter % integers.Count;
                    if (direction == "left")
                    {
                        // list = [ 1 2 3 4 5 ]
                        List<int> shiftedPart = integers.GetRange(0, counter);
                        // shiftedPart = [ 1 2 3]
                        integers.RemoveRange(0, counter);
                        // list = [ 4 5 ]
                        integers.InsertRange(integers.Count, shiftedPart);
                        // list = [ 4 5 [shiftedPart+] // 1 2 3 //]
                    }
                    else if (direction == "right")
                    {   // list = [ 1 2 3 4 5 ]
                        List<int> shiftedPartBackwards = integers.GetRange(integers.Count - counter, counter);
                        // shifted = [ 1 2 3 4 5 ]
                        integers.RemoveRange(integers.Count - counter, counter);
                        integers.InsertRange(0, shiftedPartBackwards);

                    }
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }

        private static bool IsNotValidIndex(int index, int count)
        {
            return index < 0 || index >= count;
        }
    }
}