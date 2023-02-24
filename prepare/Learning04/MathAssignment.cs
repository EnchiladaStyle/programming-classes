class MathAssignment : BaseClass
{
    private string _textbook;
    private string _problems;

    public MathAssignment(string _studentName, string _topic, string _textbook, string _problems) : base(_studentName, _topic)
    {
        this._textbook = _textbook;
        this._problems = _problems;
    }

     public string getHomeworkList()
    {
        return $"textbook: {_textbook}, problems: {_problems}";
    }
}