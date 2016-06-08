using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{

    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            first.firstName = "Ivan";
            first.lastName = "Ivanov";
            first.number = "123456789";
            School parvo = new School();
            parvo.name = "137 sou";
            parvo.city = "Sofia";

            StudentInfo(first.firstName, first.lastName, first.number);
            SchoolInfo(parvo.name, parvo.city);


            Student second = new Student();
            second.firstName = "Petkan";
            second.lastName = "Petkov";
            second.number = "987654321";
            School vtoro = new School();
            vtoro.name = "144 ou";
            vtoro.city = "Pernik";

            StudentInfo(second.firstName, second.lastName, second.number);
            SchoolInfo(vtoro.name, vtoro.city);

        }
        public static void StudentInfo(string firstName, string lastName, string number)
        {
            Console.WriteLine("{0} {1} {2}", firstName, lastName, number);
        }

        public static void SchoolInfo(string name, string city)
        {
            Console.WriteLine("{0} {1}", name, city);
        }
    }

    class Student
    {
        public string firstName;
        public string lastName;
        public string number;
    }

    class School
    {
        public string name;
        public string city;
    }
}
