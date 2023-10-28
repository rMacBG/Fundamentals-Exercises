namespace EqualSum
{
    internal class Program
    {
        static void Main()
        {
            int[] vals = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            for (int i = 0; i < vals.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += vals[j];
                }
                int rightSum = 0;
                for (int k = vals.Length - 1; k > i; k--)   
                {
                    rightSum += vals[k];

                }
                if (leftSum == rightSum && !isFound)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
                
            }
            if (!isFound)
                Console.WriteLine("no");
        }
    }
}