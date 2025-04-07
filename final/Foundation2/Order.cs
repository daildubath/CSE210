class Order
{

    private List<Product> products = new List<Product>();
    private Customer customer;
    private double totalCost;



    public Order()
    {
        customer = new Customer("Unknown", "No-Address", "City", "State/Province", "Country");
    }

    public Order(string name, string street, string city, string state, string country)
    {
        customer = new Customer(name, street, city, state, country);
    }

    public void AddProduct(string name, double pricePerUnit, int quantity)
    {
        Product product = new Product(name, pricePerUnit, quantity);
        products.Add(product);
    }

    public double GetTotalCost()
    {
        totalCost = 0.0;
        foreach (Product product in products)
        {
            totalCost += product.GetCost();
        }

        if (customer.InUSA())
        {
            totalCost += 5.00;
        }
        else
        {
            totalCost += 35.00;
        }
        return Math.Round(totalCost, 2);
    }

    public string GetCustomerLabel()
    {
        return customer.GetLabel();
    }

    public string GetPackingLabel()
    {
        string label = "Order:";
        foreach (Product product in products)
        {
            label += $"\n{product.GetLabel()}";
        }

        return label;
    }

}
