using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class Dog
    {
        private const int DefAge = 0;
        public int LegsCount { get; set; } = 4;

        public string Name { get; set; }
        public int Age { get; set; }

        public void Walk()
        {
            Console.WriteLine("i am w");
        }
        public Dog(string name)
        {
            this.Name = name;
            this.Age = DefAge;
        }
    }
}
