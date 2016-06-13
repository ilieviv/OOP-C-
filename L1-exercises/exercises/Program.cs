using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Program
    {

        static void Main()
        {
            var point = new Point(2,3);

            point.XCoordinate = 2;
            point.YCoordinate = 5;

            var secondPoint = new Point(2, 3);
            Console.WriteLine(point);
            ChangeCoordinates(point);
            Console.WriteLine(point);
             
        }

        static void ChangeCoordinates(Point point)
        {
            point.YCoordinate = 0;
            point.XCoordinate = 0;
        }

    }




}