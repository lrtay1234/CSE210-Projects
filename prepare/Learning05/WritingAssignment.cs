using System;

public class WritingAssignment : Summary
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string Title()
    {
        return _title;
    }

    public string GetTitle()
    {
        return $"{_title}";
    }
}