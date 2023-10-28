namespace RectangleAreaMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());   
            double area = RectangleArea(width, height);
            Console.WriteLine(area);
        }
        public static double RectangleArea(double width, double height)
        {

            return (width * height);
        }
    }
}