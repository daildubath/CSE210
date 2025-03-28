class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _country;


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}\n{_state} {_country}";
    }

    public bool InUSA()
    {
        return _country == "United States";
    }
}