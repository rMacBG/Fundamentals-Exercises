namespace CustomStack
{
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.isEmpty());
            string[] arr = new string[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = $"element{i}";

            }

            stack.AddRange(arr);
            Console.WriteLine(stack.Count);
        }
    }
}