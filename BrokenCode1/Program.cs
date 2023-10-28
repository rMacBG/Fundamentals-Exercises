﻿using System.Globalization;

namespace BrokenCode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                             "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                             "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;
            for (var date = startDate; date <= endDate;)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
                date = date.AddDays(1);

            }
            Console.WriteLine(holidaysCount);
        }
    }
}