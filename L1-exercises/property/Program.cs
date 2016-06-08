using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Age = 22;
            Console.WriteLine(person.Age);
        }
    }

    class Person
    {
        public int Age { get; set; }
    }
}
