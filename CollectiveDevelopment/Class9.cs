using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Принтер печатает документ");
        }
    }
}
