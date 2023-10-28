namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum += input % 10;
                input = input / 10;
            } while (input > 0);
            Console.WriteLine(sum);
        }
    }
}