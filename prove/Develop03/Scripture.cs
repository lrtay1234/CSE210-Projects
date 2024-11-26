// Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.

using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string scriptureText)
    {
        // this breaks the scriputes into "trust" "in" "the"...
        _words = new List<Word>();
        string[] splitWords = scriptureText.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
        _reference = reference;


    }
// The key behaviors for the Scripture class are to hide random words and also to get the display text as a string. 
// (The "display text" refers to the text with some words shown normally, and some replaced by underscores.)
//  It would also be nice to have a behavior to check if the scripture is completely hidden so that you know when to end the program.



    public void HideRandomWords()
    {
        Random random = new Random();
        foreach(Word word in _words)
        {
            if (random.Next(5) == 0)
            {
                word.HideWord();
            }
        }
    }
    public string GetDisplay()
    {
        List<string> displaywords = new List<string>();
        foreach(Word word in _words)
        {
            displaywords.Add(word.GetDisplayText());
        }
        // string.Join combines multiple strings in a list into one
        // "trust" "in" "the" is now "trust in the"
        // " " whatever is in between the "" will be the seperator of each indiviual string

        return $"{_reference.GetDisplayText()} - {string.Join(" ",displaywords)}";

    }

    public bool IsCompletetelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
            
        }
        return true;
    }

}