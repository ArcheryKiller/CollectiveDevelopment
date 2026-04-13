using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class Point : IMovable
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
            Console.WriteLine($"Точка перемещена в ({X}, {Y})");
        }
    }
}
