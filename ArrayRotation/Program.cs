namespace ArrayRotation
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] nums = word.Split(' ');
            for (int i = 0; i < n; i++)
            {
                var temp = nums[0];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];

                }
                nums[nums.Length - 1] = temp;

            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}