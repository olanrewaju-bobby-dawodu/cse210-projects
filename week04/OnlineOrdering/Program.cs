// Program.cs
using System;

class Program
{
    static void Main()
    {
        Address addr1 = new Address("123 Elm St.", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Doe", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Widget A", "A1", 10.99, 2));
        order1.AddProduct(new Product("Widget B", "B2", 15.50, 3));

        order1.GetPackingLabel();
        order1.GetShippingLabel();
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice():F2}");
    }
}