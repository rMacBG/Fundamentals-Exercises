using System.Diagnostics.Metrics;

namespace FundsExam2023
{
    /*
10
7
5035.5
11.3
7.2
942.3
500.57
520.68
540.87
505.99
630.3
784.20
321.21
456.8
350

12
6
4430
9.8
5.5
620.3
840.2
960.1
220
340
674
365
345.5
212
412.12
258
496
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());
            double totalWater = waterPerPerson * players * days;
            double totalFood = foodPerPerson * players * days;
            for (int i = 1; i <= days; i++)
            {
                double lostEnergy = double.Parse(Console.ReadLine());
                energy -= lostEnergy;
                if (i % 2 == 0)
                {
                    energy += energy * 0.05;
                    totalWater -= totalWater * 0.3;
                }
                if (i % 3 == 0)
                {
                    totalFood -= (totalFood / players);
                    energy += energy * 0.1;
                }               
                if (energy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
                    return;
                }
            }
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");           

        }
    }
}