using ShoppingApp.Models;

namespace ShoppingApp.Services;

public class CartService
{
    public static readonly Dictionary<Product, int> Selections = new ();

    private static void AddItem(Product product)
    {
        if (Selections.ContainsKey(product))
            return;
        
        Selections.Add(product, 1);
    }

    public static void IncreaseQuantity(Product product)
    {
        if (!Selections.ContainsKey(product))
        {
            AddItem(product: product);
            return;
        }

        if (!ProductService.CheckStock(product.Id)) return;

        Selections[product]++;
        ProductService.ReduceStock(product.Id);
    }

    public static void DecreaseQuantity(Product product)
    {
        if (!Selections.ContainsKey(product)) return;
        
        if (Selections[product] == 1)
        {
            RemoveItem(product);
            return;
        }
        
        Selections[product]--;
    }

    public static void RemoveItem(Product product)
    {
        if (!Selections.ContainsKey(product)) return;

        Selections.Remove(product);
    }
}