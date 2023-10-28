namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
           var str = new RandomList();
            Console.WriteLine(str.RandomInteger());
            str.Add("abcd");
            str.Add(1);
            str.Add("bruh");


        }
    }
}