using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numbers = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = numbers.Next(100, 201);
                Console.WriteLine(randomNumber);
            }
        }
    }
}
