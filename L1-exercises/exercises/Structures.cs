using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{

    public class Point
    {
        public Point(decimal xCoordinate, decimal yCoordinate)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }

        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }

        public override string ToString()
        {
            return $"{{{this.XCoordinate}, {this.YCoordinate}}}";
        }
    }

}
