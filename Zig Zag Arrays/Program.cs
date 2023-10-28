namespace Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main()
        {
            bool shouldTake = false;
            int val = int.Parse(Console.ReadLine());
            int[] arr1 = new int[val];
            int[] arr2 = new int[val];

            for (int i = 0; i < val; i++)
            {
                int[] values = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (shouldTake)
                {
                    arr2[i] = values[1];
                    arr1[i] = values[0];
                }
                else
                {
                    arr2[i] = values[0];
                    arr1[i] = values[1];
                }
                shouldTake = !shouldTake;
            }

            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine(string.Join(" ", arr1));
        }
    }
}