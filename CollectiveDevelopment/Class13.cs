using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public class Cash : IPayable
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата наличными: {amount:C}");
        }
    }
}
