using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // В реальной реализации — запись в файл
            Console.WriteLine($"Записано в файл: {message}");
        }
    }
}
