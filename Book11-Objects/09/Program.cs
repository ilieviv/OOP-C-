using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class TimeSpanBetweenDates
    {
        static void Main(string[] args)
        {
            int StartingYear = int.Parse(Console.ReadLine());
            int startMonth = int.Parse(Console.ReadLine());
            int startDay = int.Parse(Console.ReadLine());
            DateTime start = new DateTime(StartingYear, startMonth, startDay);
            int EndingYear = int.Parse(Console.ReadLine());
            int endMonth = int.Parse(Console.ReadLine());
            int endDay = int.Parse(Console.ReadLine());
            DateTime end = new DateTime(EndingYear, endMonth, endDay);

            int days = (int)(end - start).TotalDays;
            int weeks = days / 7;

            if (7 - (days % 7) <= (int)start.DayOfWeek)
            {
                days--;
            }
            if (7 - (days % 7) <= (int)start.DayOfWeek)
            {
                days--;
            }

            for (int i = StartingYear; i <= EndingYear; i++)
            {
                int year = i;

                DateTime[] holidays = new DateTime[10];
                holidays[0] = new DateTime(year, 3, 3);
                holidays[1] = new DateTime(year, 5, 1);
                holidays[2] = new DateTime(year, 5, 6);
                holidays[3] = new DateTime(year, 5, 24);
                holidays[4] = new DateTime(year, 9, 6);
                holidays[5] = new DateTime(year, 9, 22);
                holidays[6] = new DateTime(year, 11, 1);
                holidays[7] = new DateTime(year, 12, 24);
                holidays[8] = new DateTime(year, 12, 26);
                holidays[9] = new DateTime(year, 12, 25);
                foreach (DateTime dt in holidays)
                {
                    if ((dt > start) && (dt < end) && (dt.DayOfWeek != DayOfWeek.Saturday) && (dt.DayOfWeek != DayOfWeek.Sunday))
                        days--;
                }
            }

            days -= weeks * 2;
            Console.WriteLine(days);

        }
    }
}
