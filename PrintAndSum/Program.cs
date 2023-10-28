namespace PrintAndSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            

            for (int i = start; i <= end; i++)
            {
                
                Console.Write($"{start} ");
                sum += start;
                start++;
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}