namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("1.8l 4 cylinders", "Opel", "Corsa", 7.5, "15/3.1", "4 Door", "Medium Size", "Red LEDs", "Yellow LEDs, Longs, White LEDs", "normal", "Quartz", "Sony");
            Console.WriteLine(car);
            Vehicle vehicle = new Vehicle("1.6l 3 cyl", "Audi", "A3");
        }
    }
}