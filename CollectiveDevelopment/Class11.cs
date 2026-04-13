using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class MultifunctionDevice : IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("Многофункциональное устройство печатает документ");
        }

        public void Scan()
        {
            Console.WriteLine("Многофункциональное устройство сканирует документ");
        }

        public void Fax()
        {
            Console.WriteLine("Многофункциональное устройство отправляет факс");
        }
    }
}
