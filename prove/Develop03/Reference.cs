// Keeps track of the book, chapter, and verse information.

using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }
// The Reference class is pretty simple as far as behaviors go. It should have the ability to get the display text of
// the reference, which is just a string combining the book, chapter, and verse (or verses). You could consider having 
// getters and setters for each of the data elements that this class stores, but it may be even better to use a 
// constructor to set them. The constructor will be discussed in more detail below.
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }


    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;

    }
    public int? GetEndVerse()
    {
        return _endVerse;
    }



    public string GetDisplayText()
    {  
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}


    // getters and setter...