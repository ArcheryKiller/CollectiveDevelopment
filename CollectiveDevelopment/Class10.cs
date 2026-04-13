using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Сканер сканирует документ");
        }
    }
}
