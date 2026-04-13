using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public static class PaymentProcessor
    {
        public static void ProcessPayment(IPayable method, decimal amount)
        {
            method.Pay(amount);
        }
    }
}
