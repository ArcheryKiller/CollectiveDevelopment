using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class Cube : I3DShape
    {
        private double side;

        public Cube(double side)
        {
            this.side = side;
        }

        public double GetArea() => 6 * side * side;
        public double GetPerimeter() => 12 * side;
        public double GetVolume() => side * side * side;
    }
}
