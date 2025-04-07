class Reception : Event
{
    private string _email;

    public Reception() : base()
    {
        _email = "No email provided.";
        SetType("Reception");
    }

    public Reception(string title, string description, string date, string time, string email): base(title, description, date, time)
    {
        _email = email;
        SetType("Reception");
    }

    public override string FullDetails()
    {
        return  $"{StandardDetails()}\n" +
                $"RSVP email: {_email}";
    }
}