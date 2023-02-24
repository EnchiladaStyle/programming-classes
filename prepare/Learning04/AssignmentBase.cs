using System;

class BaseClass
{
    private string _studentName;
    private string _topic;

    public BaseClass(string _studentName, string _topic)
    {
        this._studentName = _studentName;
        this._topic = _topic;
    }

    public string getSummary()
    {
        return $"name: {_studentName}, topic: {_topic}";
    }
}