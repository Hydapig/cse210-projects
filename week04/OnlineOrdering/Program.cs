using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("4 Pivet Drive","Little Whinging", "Surrey", "UK");
        Customer customer1 = new Customer("Harry Potter", address1);

        Address address2 = new Address("508 Saint Cloud Road", "Los Angeles", "California", "USA");
        Customer customer2 = new Customer("Carlton Banks", address2);

        Order order1 = new Order(customer1);
        order1.AddProducts(new Product("Cauldron", "CP2", 35, 1));
        order1.AddProducts(new Product("Wand","WP1", 100, 1));
        order1.AddProducts(new Product("Plain Work Robes", "PWR01", 15, 3));

        Order order2 = new Order(customer2);
        order2.AddProducts(new Product("Sweater", "SWT11", 10.99, 3));
        order2.AddProducts(new Product("Polo Shirt", "PS24", 8.99, 5));
        order2.AddProducts(new Product("Tom Jones: It's Not Unusual Special Edition Vinyl","V1965", 21.95,1));

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("\nShipping Label");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("\nShipping Label");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost()}");
    }
}