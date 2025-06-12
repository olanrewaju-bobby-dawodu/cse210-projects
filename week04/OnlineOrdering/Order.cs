
using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (var product in _products)
        {
            Console.WriteLine($"- {product.Name} (ID: {product.ProductId})");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(_customer.Name);
        Console.WriteLine(_customer.Address.GetFullAddress());
    }
}