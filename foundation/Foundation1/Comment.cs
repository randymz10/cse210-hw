class Comment
{
    private string _userName;
    private string _text;

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    public string ShowComment()
    {
        return $"{_userName}: {_text}";
    }
}