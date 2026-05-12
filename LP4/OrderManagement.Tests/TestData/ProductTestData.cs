using Xunit;
using System.Collections.Generic;
using DevelopmentOfUnitTests;

namespace OrderManagement.Tests.TestData;

/// <summary>Данные для тестирования заказов с разными наборами товаров</summary>
public class ProductTestData : TheoryData<List<Product>, decimal>
{
    public ProductTestData()
    {
        // Тест 1: Несколько товаров
        Add(new List<Product>
        {
            new() { Id = 1, Name = "Laptop", Price = 1000 },
            new() { Id = 2, Name = "Mouse", Price = 50 }
        }, 1050m);

        // Тест 2: Один товар
        Add(new List<Product>
        {
            new() { Id = 6, Name = "Tablet", Price = 600 }
        }, 600m);

        // Тест 3: Товар с нулевой ценой
        Add(new List<Product>
        {
            new() { Id = 4, Name = "Free Gift", Price = 0 }
        }, 0m);

        // Тест 4: Дорогие товары (для проверки 10% скидки)
        Add(new List<Product>
        {
            new() { Id = 5, Name = "Gaming PC", Price = 1500 },
            new() { Id = 6, Name = "Tablet", Price = 600 }
        }, 2100m);
    }
}
