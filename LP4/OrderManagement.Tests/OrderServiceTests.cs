using DevelopmentOfUnitTests;
using Xunit;
using System.Collections.Generic;
using OrderManagement.Tests.TestData;

namespace OrderManagement.Tests;

/// <summary>Тесты для сервиса управления заказами</summary>
public class OrderServiceTests
{
    private readonly OrderService _orderService;

    public OrderServiceTests()
    {
        _orderService = new OrderService();
    }

    #region Тесты метода CreateOrder

    [Fact]
    public void CreateOrder_WithValidProducts_ReturnsOrderWithCorrectProperties()
    {
        // Arrange
        var products = MockData.GetSampleProducts();

        // Act
        var result = _orderService.CreateOrder(products);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(3, result.Products.Count);
        Assert.Equal(1130, result.TotalAmount);
        Assert.Equal("Pending", result.Status);
        Assert.True(result.Id > 0);
    }

    [Theory]
    [ClassData(typeof(ProductTestData))]
    public void CreateOrder_WithComplexProducts_ReturnsCorrectTotal(List<Product> products, decimal expectedTotal)
    {
        // Arrange & Act
        var order = _orderService.CreateOrder(products);

        // Assert
        Assert.Equal(expectedTotal, order.TotalAmount);
    }

    [Fact]
    public void CreateOrder_WithEmptyProducts_ThrowsArgumentException()
    {
        // Arrange
        List<Product> emptyProducts = new();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _orderService.CreateOrder(emptyProducts));
    }

    [Fact]
    public void CreateOrder_WithNullProducts_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _orderService.CreateOrder(null));
    }

    #endregion

    #region Тесты метода UpdateOrderStatus

    [Fact]
    public void UpdateOrderStatus_WithExistingOrder_UpdatesStatusSuccessfully()
    {
        // Arrange
        var products = MockData.GetSampleProducts();
        var order = _orderService.CreateOrder(products);
        var newStatus = "Shipped";

        // Act
        var result = _orderService.UpdateOrderStatus(order.Id, newStatus);

        // Assert
        Assert.True(result);
        Assert.Equal(newStatus, order.Status);
    }

    [Fact]
    public void UpdateOrderStatus_WithNonExistingOrder_ReturnsFalse()
    {
        // Arrange
        var nonExistingId = 999;
        var newStatus = "Cancelled";

        // Act
        var result = _orderService.UpdateOrderStatus(nonExistingId, newStatus);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void UpdateOrderStatus_CancelShippedOrder_ThrowsInvalidOperationException()
    {
        // Arrange
        var products = MockData.GetSampleProducts();
        var order = _orderService.CreateOrder(products);
        _orderService.UpdateOrderStatus(order.Id, "Shipped");

        // Act & Assert
        Assert.Throws<InvalidOperationException>(
            () => _orderService.UpdateOrderStatus(order.Id, "Cancelled")
        );
    }

    #endregion

    #region Тесты метода CalculateDiscount

    [Fact]
    public void CalculateDiscount_WithHighValueOrder_Returns10PercentDiscount()
    {
        // Arrange
        var expensiveProduct = MockData.GetExpensiveProduct();
        var order = _orderService.CreateOrder(new List<Product> { expensiveProduct });

        // Act
        var discount = _orderService.CalculateDiscount(order);

        // Assert
        Assert.Equal(150m, discount); // 1500 * 0.1 = 150
    }

    [Fact]
    public void CalculateDiscount_WithMediumValueOrder_Returns5PercentDiscount()
    {
        // Arrange
        var mediumProduct = MockData.GetMediumPriceProduct();
        var order = _orderService.CreateOrder(new List<Product> { mediumProduct });

        // Act
        var discount = _orderService.CalculateDiscount(order);

        // Assert
        Assert.Equal(30m, discount); // 600 * 0.05 = 30
    }

    [Fact]
    public void CalculateDiscount_WithLowValueOrder_ReturnsNoDiscount()
    {
        // Arrange
        var freeProduct = MockData.GetFreeProduct();
        var order = _orderService.CreateOrder(new List<Product> { freeProduct });

        // Act
        var discount = _orderService.CalculateDiscount(order);

        // Assert
        Assert.Equal(0m, discount);
    }

    [Fact]
    public void CalculateDiscount_WithNullOrder_ReturnsZero()
    {
        // Act
        var discount = _orderService.CalculateDiscount(null);

        // Assert
        Assert.Equal(0m, discount);
    }

    #endregion
}
