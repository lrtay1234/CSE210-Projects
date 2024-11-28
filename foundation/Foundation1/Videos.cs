using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class Videos
{
    public string _author;
    public string _name;
    public double _length; 
    public List<Comments> _comments;

    public Videos (string author, string name, double length)
    {
        _author = author;
        _name = name;
        _length = length;
        _comments = new List<Comments>();
    }

    public void AddComments(string name, string comment)
    {
        _comments.Add(new Comments (name, comment));
    }

    public int GetNumberComments()
    {
        return _comments.Count;
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Title: {_name}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {_comments.Count}");
        Console.WriteLine($"Comments: ");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment._name} - {comment._text}");
        }
    }


}