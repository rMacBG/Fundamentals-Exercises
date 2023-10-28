namespace SubtractOddAndEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
               int currentNumber = arr[i];
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else if (currentNumber % 2 != 0)
                {
                    oddSum += currentNumber;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}