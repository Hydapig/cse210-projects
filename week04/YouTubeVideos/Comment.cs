public class Comment
{
    string _userName;
    string _commentText;

    public Comment(string user, string text)
    {
        _userName = user;
        _commentText = text;
    }

    public string DisplayComment()
    {
        return $"{_userName}\n{_commentText}";
    }
}