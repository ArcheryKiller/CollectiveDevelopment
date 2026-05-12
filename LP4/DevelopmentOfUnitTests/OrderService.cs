using System.Collections.Generic;
using System.Linq;

namespace DevelopmentOfUnitTests;

/// <summary>Сервис для управления заказами</summary>
public class OrderService
{
    private readonly List<Order> _orders = new();
    private int _nextOrderId = 1;

    /// <summary>Создаёт новый заказ</summary>
    public Order CreateOrder(List<Product> products)
    {
        if (products == null || !products.Any())
            throw new ArgumentException("Order must contain at least one product");

        var order = new Order
        {
            Id = _nextOrderId++,
            Products = products,
            Status = "Pending"
        };

        _orders.Add(order);
        return order;
    }

    /// <summary>Обновляет статус заказа</summary>
    public bool UpdateOrderStatus(int orderId, string newStatus)
    {
        var order = _orders.FirstOrDefault(o => o.Id == orderId);
        if (order == null) return false;

        if (order.Status == "Shipped" && newStatus == "Cancelled")
            throw new InvalidOperationException("Cannot cancel shipped order");

        order.Status = newStatus;
        return true;
    }

    /// <summary>Рассчитывает скидку для заказа</summary>
    public decimal CalculateDiscount(Order order)
    {
        if (order == null) return 0m;

        var total = order.TotalAmount;
        if (total > 1000) return total * 0.1m; // 10%
        if (total > 500) return total * 0.05m; // 5%
        return 0m;
    }
}
