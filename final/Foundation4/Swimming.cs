class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override string GetName()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / GetLength() * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetLength() / GetDistance(), 2);
    }
}