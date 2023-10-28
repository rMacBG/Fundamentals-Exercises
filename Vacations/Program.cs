namespace Vacations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            switch (type)
            {
                case "Students":
                    double totalPrice;
                    if (day == "Friday")
                    {
                        totalPrice = num * 8.45;
                        if (num >= 30)
                        {
                            totalPrice = totalPrice - totalPrice * 0.15;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = num * 9.80;
                        if (num >= 30)
                        {
                            totalPrice = totalPrice - totalPrice * 0.15;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = num * 10.46;
                        if (num >= 30)
                        {
                            totalPrice = totalPrice - totalPrice * 0.15;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    break;
                case "Business":

                    if (day == "Friday")
                    {
                        if (num >= 100)
                        {
                            totalPrice = (num - 10) * 10.90;
                        }
                        else
                        {
                            totalPrice = num * 10.90;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    else if (day == "Saturday")
                    {
                        if (num >= 100)
                        {
                            totalPrice = (num - 10) * 15.60;
                        }
                        else
                        {
                            totalPrice = num * 15.60;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    else if (day == "Sunday")
                    {
                        if (num >= 100)
                        {
                            totalPrice = (num - 10) * 16;
                        }
                        else
                        {
                            totalPrice = num * 16;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        totalPrice = num * 15.0;
                        if (num >= 10 && num <= 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.05;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = num * 20.0;
                        if (num >= 10 && num <= 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.05;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = num * 22.50;
                        if (num >= 10 && num <= 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.05;
                        }
                        Console.WriteLine($"Total price: {totalPrice:f2}");
                    }
                    break;
            }
        }
    }
}