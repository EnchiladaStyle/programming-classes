class Writing : BaseClass
{
    private string _title;

    public Writing(string _studentName, string _topic, string _title) : base(_studentName, _topic)
    {
        this._title = _title;
    }

    public string getWritingInfo()
    {
        return $"title: {_title}";
    }
}