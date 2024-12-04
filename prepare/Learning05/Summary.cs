using System;

public class Summary
{
    private string _name;
    private string _topic;


    public Summary(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }
    
    public string name()
    {
        return _name;
    }

    public string topic()
    {
        return _topic;
    }


    public string getSummary()
    {
        return $"Student: {_name} \nTopic: {_topic}";
    }
    }

