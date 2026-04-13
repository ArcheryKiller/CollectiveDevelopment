using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public static class ShapeUtils
{
    public static void PrintShapeInfo(IShape shape)
    {
        Console.WriteLine($"Площадь: {shape.GetArea():F2}");
        Console.WriteLine($"Периметр: {shape.GetPerimeter():F2}");
    }
}
}
