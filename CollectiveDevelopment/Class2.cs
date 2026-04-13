using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуется круг с радиусом {radius}");
        }
    }
}
