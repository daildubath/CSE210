class Product
{
    Random random = new Random();
    private string _name;
    private double _pricePerUnit;
    private int _quantity;
    private string _productID;

    public Product()
    {
        _name = "Unknown";
        _pricePerUnit = 0.0;
        _quantity = 0;
        _productID = random.Next(10000000, 99999999).ToString();
    }

    public Product(string name, double pricePerUnit, int quantity)
    {
        _name = name;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
        _productID = random.Next(10000000, 99999999).ToString();
    }

    public double GetCost()
    {
        return Math.Round(_pricePerUnit * _quantity, 2);
    }

    public string GetLabel()
    {
        string front = $"{_productID} {_name}".PadRight(25);
        string back = $"Quantity: {_quantity}".PadLeft(15);
        return String.Concat(front, back);
    }

}