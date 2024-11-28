using System;

class Program
{
    static void Main(string[] args)
    {
        // Object: Creating an instance of the Reference class
        Reference reference = new Reference("Proverbs", 3, 5);
        
        // Attribute: Scripture text
        string scriptureText = "Trust in the Lord with all thine heart, and lean not unto thine own understanding";

        // Object: Creating an instance of the Scripture class
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Here is your scripture, Good Luck!!");
        // Behavior: Displaying the scripture
        Console.WriteLine(scripture.GetDisplay());
        Console.ReadLine(); 

        string userinput = "no";
        while (!scripture.IsCompletelyHidden() && userinput != "yes")
        {
            // Behavior: Hiding random words in the scripture
            scripture.HideRandomWords();

            Console.Clear();
            Console.WriteLine("\nScripture with Hidden Words:");
            // Behavior: Displaying the scripture with hidden words
            Console.WriteLine(scripture.GetDisplay());
            Console.WriteLine("Would you like to quit?");
            userinput = Console.ReadLine();
        }
    }
}
```

### Scripture Class

using System;
using System.Collections.Generic;

// Class: Scripture
public class Scripture
{
    // Encapsulation: Private fields
    private List<Word> _words;
    private Reference _reference;

    // Constructor: Initializes the scripture with reference and text
    public Scripture(Reference reference, string scriptureText)
    {
        _words = new List<Word>();
        string[] splitWords = scriptureText.Split(" ");
        foreach (string word in splitWords)
        {
            // Object: Creating instances of the Word class
            _words.Add(new Word(word));
        }
        _reference = reference;
    }

    // Method: Hides random words in the scripture
    public void HideRandomWords()
    {
        Random random = new Random();
        foreach (Word word in _words)
        {
            if (random.Next(5) == 0)
            {
                word.HideWord();
            }
        }
    }

    // Method: Gets the display text of the scripture
    public string GetDisplay()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} - {string.Join(" ", displayWords)}";
    }

    // Method: Checks if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
```

### Reference Class

using System;

// Class: Reference
public class Reference
{
    // Encapsulation: Private fields
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    // Constructor: Initializes the reference with book, chapter, and verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    // Constructor: Initializes the reference with book, chapter, start verse, and end verse
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Method: Gets the display text of the reference
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
```

### Word Class

using System;

// Class: Word
public class Word
{
    // Encapsulation: Private fields
    private string _text;
    private bool _isHidden;

    // Constructor: Initializes the word with text
    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }

    // Method: Hides the word
    public void HideWord()
    {
        _isHidden = true;
    }

    // Method: Shows the word
    public void ShowWord()
    {
        _isHidden = false;
    }

    // Method: Checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method: Gets the display text of the word
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
