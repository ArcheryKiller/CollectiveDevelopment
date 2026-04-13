using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class CircleShape : IShape
    {
        private double radius;

        public CircleShape(double radius)
        {
            this.radius = radius;
        }

        public double GetArea() => Math.PI * radius * radius;
        public double GetPerimeter() => 2 * Math.PI * radius;
    }
}
