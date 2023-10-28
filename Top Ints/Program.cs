namespace Top_Ints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                bool biggest = true;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        biggest = false;
                    }
                }
                if (biggest)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
        }
    }
}