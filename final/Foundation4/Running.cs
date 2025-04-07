class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string GetName()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round(_distance / GetLength() * 60, 2);
    }   

    public override double GetPace()
    {
        return Math.Round(GetLength() / _distance, 2);
    }



}