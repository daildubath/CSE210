class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        int lengthMin = (_length / 60);
        int lengthSec = (_length % 60);

        System.Console.WriteLine("_______________________________________________");
        System.Console.WriteLine($"Title: {_title}");
        System.Console.WriteLine($"Author: {_author}");
        System.Console.WriteLine($"Length: {lengthMin}:{lengthSec}");
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        System.Console.WriteLine("Comments:");
        System.Console.WriteLine("----------------------------------------");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        System.Console.WriteLine("______________________________________________");
    }
}