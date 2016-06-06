using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {


        static double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }

        static double Area(double a, double h)
        {
            return a * h / 2;
        }

        static double Area(double a, double b, float angle)
        {
            return a * b * Math.Sin(angle * Math.PI / 180) / 2;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    Console.WriteLine("Input a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input c: ");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine(Area(a, b, c));
                    return;
                case "b":
                    Console.WriteLine("Input a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input h: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine(Area(a, h));
                    return;
                case "c":
                    Console.WriteLine("Input a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input h: ");
                    h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input angle: ");
                    float angle = float.Parse(Console.ReadLine());
                    Console.WriteLine(Area(a, h, angle));
                    return;
                default:
                    Console.WriteLine("Please, input a, b or c as a subtask choice!");
                    return;
            }
        }
    }
}

