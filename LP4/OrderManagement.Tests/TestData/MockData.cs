using System.Collections.Generic;
using DevelopmentOfUnitTests;

namespace OrderManagement.Tests.TestData;

/// <summary>Статические тестовые данные для заказов</summary>
public static class MockData
{
    /// <summary>Возвращает набор тестовых товаров</summary>
    public static List<Product> GetSampleProducts() => new()
    {
        new() { Id = 1, Name = "Laptop", Price = 1000 },
        new() { Id = 2, Name = "Mouse", Price = 50 },
        new() { Id = 3, Name = "Keyboard", Price = 80 }
    };

    /// <summary>Возвращает товар с нулевой ценой</summary>
    public static Product GetFreeProduct() => new()
    {
        Id = 4,
        Name = "Free Gift",
        Price = 0
    };

    /// <summary>Возвращает дорогой товар (для проверки скидки 10%)</summary>
    public static Product GetExpensiveProduct() => new()
    {
        Id = 5,
        Name = "Gaming PC",
        Price = 1500
    };

    /// <summary>Возвращает средний по цене товар (для проверки скидки 5%)</summary>
    public static Product GetMediumPriceProduct() => new()
    {
        Id = 6,
        Name = "Tablet",
        Price = 600
    };
}
