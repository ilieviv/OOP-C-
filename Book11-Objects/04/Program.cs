using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTicks = DateTime.Now.AddMilliseconds(Environment.TickCount);
            Console.WriteLine(dateTicks - DateTime.Now);
        }
    }
}
