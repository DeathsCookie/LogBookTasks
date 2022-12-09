namespace ShoppingApp.Models;

public sealed class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Stock { get; set; } = 0;

    public double Cost { get; set; } = 0.0;
}