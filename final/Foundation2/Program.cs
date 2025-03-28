using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order("Ben", "123 Main St", "Springfield", "IL", "United States");
        order.AddProduct("Elf", 19.99, 2);
        order.AddProduct("Gnome", 12.35, 1);
        order.AddProduct("Dwarf", 15.99, 3);

        System.Console.WriteLine(order.GetCustomerLabel());
        System.Console.WriteLine(order.GetPackingLabel());
        System.Console.WriteLine($"${order.GetTotalCost()}");

        Order order2 = new Order("Charlie"  , "SanSomething", "thePlace", "someplace", "Spain");
        order2.AddProduct("Elfe", 15.56, 1);
        order2.AddProduct("Gnomo", 12.80, 7);
        order2.AddProduct("Dwarfa", 15.79, 3);

        System.Console.WriteLine(order2.GetCustomerLabel());
        System.Console.WriteLine(order2.GetPackingLabel());
        System.Console.WriteLine($"${order2.GetTotalCost()}");


    }
}