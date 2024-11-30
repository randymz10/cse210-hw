using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>{
            new Product("Samsung A12", 300.00, 3),
            new Product("Samsung A15", 1200.00, 5),
        };
        Customer customer1 = new Customer("Randy Muñoz", "Av Camilly Fernandes Rodrigues", "Londrina", "Paraná", "Brazil");

        Order order1 = new Order(products1, customer1);
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total price: {order1.TotalCost()}");

        Console.WriteLine("_________________________________________\n");

        List<Product> products2 = new List<Product>{
            new Product("Iphone 13", 10000.79, 1),
            new Product("Samsung Galaxy S23", 2330.45, 2),
        };
        Customer customer2 = new Customer("Maralied Tafur", "Calle Bolivar", "Carupano", "Sucre", "USA");

        Order order2 = new Order(products2, customer2);
        
        Console.WriteLine("Order 2");
        Console.WriteLine("Packing label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total price: {order2.TotalCost()}");
    }
}