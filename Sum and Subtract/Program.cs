using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace Sum_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            
            
            Subtract(num1, num2, num3);

        }

        static void Sum(int num1, int num2)
        {
            int sum = 0;
            sum += num1 + num2;
        }
        static void Subtract(int num1,int num2, int num3)
        {
            int total = 0;
            Sum(num1, num2);
           

        }
    }
}