using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(result);
        }
    }
}
