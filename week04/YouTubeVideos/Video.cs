public class Video 
{
    string _title;
    string _author;
    int _length;
    List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
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
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds\n");
        Console.WriteLine($"Comments ({GetNumberofComments()}):");
        foreach (var c in comments)
        {
            Console.WriteLine($"{c.DisplayComment()}");
        }        
    }
}