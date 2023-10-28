namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCap = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end") 
            {
                string[] arguments = input.Split();
                if (arguments[0] == "Add")
                {
                    int passengers = int.Parse(arguments[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int newPassengers = int.Parse(arguments[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= maxCap)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}