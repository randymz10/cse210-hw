class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbookSection, string problem, string studentName, string topic) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problem;
    }

    public string GetHomeWorkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}