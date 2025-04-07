class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture() : base()
    {
        _speaker = "Undecided";
        _capacity = 0;
        SetType("Lecture");
    }
    public Lecture(string eventTitle, string description, string date, string time, string speaker, int capacity): base(eventTitle, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
        SetType("Lecture");
    }

    public override string FullDetails()
    {
        return  $"{StandardDetails()}\n" +
                $"Speaker: {_speaker}\n" +
                $"Capacity: {_capacity} people";
    }

}