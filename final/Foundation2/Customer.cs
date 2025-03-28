class Customer
{

    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }

    public string GetLabel()
    {
        return $"Ship to: {_name}\n{_address.GetAddress()}";
    }
}