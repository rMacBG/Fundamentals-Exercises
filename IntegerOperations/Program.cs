namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            while (counter != 4)
            {
                sum += input;
                counter++;
                input = int.Parse(Console.ReadLine());
                counter++;
                sum += input;
                if (counter == 2)
                {
                    input = int.Parse(Console.ReadLine());
                    counter++;
                    sum /= input;
                }
                if (counter == 3)
                {
                    input = int.Parse(Console.ReadLine());
                    counter++;
                    sum *= input;
                }
            }
            Console.WriteLine(sum);
        }
    }
}