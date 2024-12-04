using System;

public class MathAssignments : Summary
{
    private string _textbookSection;
    private string _problems;

    public MathAssignments(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string TextbookSection()
    {
        return _textbookSection;
    }

    public string Problems()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}