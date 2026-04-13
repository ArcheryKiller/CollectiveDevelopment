using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class RectangleShape : IShape
    {
        private double width;
        private double height;

        public RectangleShape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea() => width * height;
        public double GetPerimeter() => 2 * (width + height);
    }
}
