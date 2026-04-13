using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            var point = new Point(0, 0);
            point.Move(5, 3);

            var shapes = new List<IDrawable>
        {
            new Circle(10),
            new Rectangle(5, 8)
        };
            DrawingUtils.DrawAll(shapes);

            // Задание 2
            IShape circle = new CircleShape(5);
            IShape rectangle = new RectangleShape(4, 6);
            ShapeUtils.PrintShapeInfo(circle);
            ShapeUtils.PrintShapeInfo(rectangle);

            I3DShape cube = new Cube(3);
            Console.WriteLine($"Объем куба: {cube.GetVolume():F2}");

            // Задание 3
            var printer = new Printer();
            printer.Print();

            var scanner = new Scanner();
            scanner.Scan();

            var multifunction = new MultifunctionDevice();
            multifunction.Print();
            multifunction.Scan();
            multifunction.Fax();

            // Задание 4
            PaymentProcessor.ProcessPayment(new CreditCard(), 1000m);
            PaymentProcessor.ProcessPayment(new Cash(), 500m);

            Worker.DoWork(new ConsoleLogger());
            Worker.DoWork(new FileLogger());
        }
    }
}
