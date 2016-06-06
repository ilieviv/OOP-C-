using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();

            for (int i = 0; i < 6; i++)
            {
                int randomNum = num.Next(49) + 1;
                Console.WriteLine(randomNum);
            }

        }

    }
}


