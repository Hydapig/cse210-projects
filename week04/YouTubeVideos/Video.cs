public class Video 
{
    string _title;
    string _author;
    int _length;
    List<Comment> comments = new List<Comment>();

    // methods
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length
    }

    public void AddComments(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberofComments()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title} by {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetNumberofComments()}):");
        foreach (var c in comments)
        {
            Console.WriteLine($"{c}");
        }        
    }
}