using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {

        static int StringToSum(string input)
        {
            int sum = 0;
            input = input.Trim();
            string[] array = input.Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                sum += int.Parse(array[i]);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(StringToSum(input));
        }
    }
}
