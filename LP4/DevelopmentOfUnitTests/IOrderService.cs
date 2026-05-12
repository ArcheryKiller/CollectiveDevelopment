using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentOfUnitTests;

public interface IOrderService
{
    Order CreateOrder(List<Product> products);
    bool UpdateOrderStatus(int orderId, string newStatus);
    decimal CalculateDiscount(Order order);
}
