namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int cap = 255;
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                int fill = int.Parse(Console.ReadLine());

                if (sum + fill > cap)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += fill;
                }

            }
            Console.WriteLine(sum);
        }
    }
}