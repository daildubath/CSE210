class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _street = "Unknown Street";
        _city = "Unknown City";
        _state = "Unknown State";
        _country = "Unknown Country";
    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}";
    }
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}