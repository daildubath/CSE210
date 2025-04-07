class Cycling : Activity
{
    private double _speed;


    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string GetName()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return Math.Round(_speed * GetLength() / 60, 2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}