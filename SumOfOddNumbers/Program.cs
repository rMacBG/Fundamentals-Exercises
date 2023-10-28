namespace SumOfOddNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", -1 + i * 2);
                sum += -1 + i * 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }   
    }
}