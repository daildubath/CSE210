abstract class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event()
    {
        _eventTitle = "Unnamed Event";
        _description = "No description provided.";
        _date = "Unset";
        _time = "Unset";
        _address = new Address();
    }

    public void SetType(string eventType)
    {
        _eventType = eventType;
    }

    public Event(string eventTitle, string description, string date, string time)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address();
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }

    public string StandardDetails()
    {
        return $"Event Title: {_eventTitle}\n" +
               $"Description: {_description}\n" +
               $"Date: {_date}\n" +
               $"Time: {_time}\n" +
               $"Address: {_address}";
    }
    public abstract string FullDetails();

    public string ShortDescription()
    {
        return $"{_eventTitle} - {_eventType} event: {_date}";
    }

}