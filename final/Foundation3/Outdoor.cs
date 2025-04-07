class Outdoor : Event
{
    private string _weather;

    public Outdoor() : base()
    {
        _weather = "To be determined by God";
        SetType("Outdoor");
    }

    public Outdoor(string title, string description, string date, string time, string weather): base(title, description, date, time)
    {
        _weather = weather;
        SetType("Outdoor");
    }

    public override string FullDetails()
    {
        return  $"{StandardDetails()}\n" +
                $"Weather: {_weather}";
    }
}