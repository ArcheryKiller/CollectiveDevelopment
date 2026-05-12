using System.Collections.Generic;
using System.Linq;

namespace DevelopmentOfUnitTests;

public class Order
{
    public int Id { get; set; }
    public List<Product> Products { get; set; } = new();

    public decimal TotalAmount => Products.Sum(p => p.Price);
    public string Status { get; set; } = "Pending";
}
