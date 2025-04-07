abstract class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract string GetName();

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_length} min) - Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
    
    public int GetLength()
    {
        return _length;
    }
 
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
}
