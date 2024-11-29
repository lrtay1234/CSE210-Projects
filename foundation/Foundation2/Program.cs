using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
            //                                      the m is used for demical 
        order1.AddProduct(new Product("Widget", "W123", 10.00m, 2));
        order1.AddProduct(new Product("Gadget", "G456", 15.00m, 1));

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", "T789", 20.00m, 3));
        order2.AddProduct(new Product("Doohickey", "D012", 25.00m, 2));

        Console.WriteLine(order1.GetLabel());
        Console.WriteLine(order1.GetShippingAddress());
        Console.WriteLine($"Total Cost: ${order1.totalCost()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetLabel());
        Console.WriteLine(order2.GetShippingAddress());
        Console.WriteLine($"Total Cost: ${order2.totalCost()}");
    }
}