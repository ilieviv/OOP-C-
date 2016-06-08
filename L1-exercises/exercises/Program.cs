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
            //Student first = new Student();
            //first.FirstName = Console.ReadLine();
            //first.LastName = "qqqqqqqqqqq";
            //first.number = "33";

            //string fullName = first.FullName;
            //Console.WriteLine(fullName);

            Person ivo = new Person(33);

        }
        public static void StudentInfo(string firstName, string lastName, string number)
        {
            Console.WriteLine("{0} {1} {2}", firstName, lastName, number);
        }
    }

    class Student
    {
        public string firstName;
        public string lastName;
        public string number;

        public string FirstName
        {
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            set
            {
                if (value.Length > 5)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Must be at laeast 5 sym");
                }
            }
        }

        public string FullName
        {
            get
            {
                return $"{firstName} {lastName} {number}";
            }
        }
    }
    class Person
    {
        private int street;

        public Person(int street)
        {
            this.street = street;
            Console.WriteLine(street);
        }
        
    }
}
