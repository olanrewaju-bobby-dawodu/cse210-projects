using System;
using System.Collections.Generic;

// Represents a single item in an order
public class OrderItem
{
    private string itemName;
    private int quantity;
    private double pricePerUnit;

    public OrderItem(string itemName, int quantity, double pricePerUnit)
    {
        this.itemName = itemName;
        this.quantity = quantity;
        this.pricePerUnit = pricePerUnit;
    }

    public double GetTotalPrice()
    {
        return quantity * pricePerUnit;
    }

    public void ShowItem()
    {
        Console.WriteLine($"{itemName} - Quantity: {quantity}, Price per unit: ${pricePerUnit:F2}");
    }
}

// Represents a customer placing an order
public class Customer
{
    private string name;
    private string email;

    public Customer(string name, string email)
    {
        this.name = name;
        this.email = email;
    }

    public void ShowCustomer()
    {
        Console.WriteLine($"Customer: {name}, Email: {email}");
    }
}

// Represents an order with encapsulated data
public class Order
{
    private Customer customer;
    private List<OrderItem> items;

    public Order(Customer customer)
    {
        this.customer = customer;
        items = new List<OrderItem>();
    }

    // Add item to order
    public void AddItem(OrderItem item)
    {
        items.Add(item);
    }

    // Calculate total cost
    public double GetTotalAmount()
    {
        double total = 0;
        foreach (var item in items)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }

    // Show order summary
    public void ShowOrder()
    {
        customer.ShowCustomer();
        Console.WriteLine("Order Items:");
        foreach (var item in items)
        {
            item.ShowItem();
        }
        Console.WriteLine($"Total Amount: ${GetTotalAmount():F2}");
    }
}

// Program to demonstrate usage
public class Program2
{
    public static void Main()
    {
        Customer customer = new Customer("Alice Johnson", "alice@example.com");
        Order order = new Order(customer);

        order.AddItem(new OrderItem("Laptop", 1, 999.99));
        order.AddItem(new OrderItem("Wireless Mouse", 2, 25.50));
        order.AddItem(new OrderItem("Keyboard", 1, 49.99));

        order.ShowOrder();
    }
}
