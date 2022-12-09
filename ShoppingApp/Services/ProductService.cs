using ShoppingApp.Models;

namespace ShoppingApp.Services;

public class ProductService
{
    public static readonly List<Product> Products = new()
    {
        new Product
        {
            Id = 0,
            Name = "League of Legends",
            Cost = 10.99,
            Stock = 5
        },
        new Product
        {
            Id = 1,
            Name = "Dota 2",
            Cost = 15.99,
            Stock = 10
        },
        new Product
        {
            Id = 2,
            Name = "Fangs",
            Cost = 5.99,
            Stock = 35
        },
        new Product
        {
            Id = 3,
            Name = "Smite",
            Cost = 12.50,
            Stock = 14
        },
        new Product
        {
            Id = 4,
            Name = "Overwatch 2",
            Cost = 29.99,
            Stock = 20
        }
    };

    public static bool CheckStock(int id)
    {
        if (!Products.Exists(x => x.Id == id)) return false;

        return Products.First(x => x.Id == id).Stock > 0;
    }

    public static bool ReduceStock(int id)
    {
        if (!Products.Exists(x => x.Id == id)) return false;

        Products.First(x => x.Id == id).Stock--;
        return true;
    }

    public static bool AddStock(int id)
    {
        if (!Products.Exists(x => x.Id == id)) return false;

        Products.First(x => x.Id == id).Stock++;
        return true;
    }
}