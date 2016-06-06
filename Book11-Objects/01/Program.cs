using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());
            DateTime Date = new DateTime(year);

            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
