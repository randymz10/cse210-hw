class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public string ShowInformation()
    {
        string comments = "";
        _comments.ForEach(comment => comments += comment.ShowComment() + "\n");

        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length}\nComments:\n{comments}";
    }
}