namespace DevelopmentOfUnitTests;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order Management Application");

        var service = new OrderService();

        var products = new List<Product>
        {
            new() { Id = 1, Name = "Laptop", Price = 1000 },
            new() { Id = 2, Name = "Mouse", Price = 50 }
        };

        var order = service.CreateOrder(products);
        Console.WriteLine($"Created order {order.Id}, total: {order.TotalAmount}");
    }
}
