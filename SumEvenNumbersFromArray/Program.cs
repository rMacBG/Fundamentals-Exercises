namespace SumEvenNumbersFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int crtnum = nums[i];
                if (crtnum % 2 == 0)
                {
                    sum += crtnum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}