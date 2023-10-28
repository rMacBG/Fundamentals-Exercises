namespace DeclaringAndInvoking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberCheck();

            static void NumberCheck()
            {
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine($"The number {num} is positive.");

                }
                else if (num < 0)
                {
                    Console.WriteLine($"The number {num} is negative.");
                }
                else { Console.WriteLine($"The number {num} is zero.");
                }
            }
        }
    }
}