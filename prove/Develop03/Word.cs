// Keeps track of a single word and whether it is shown or hidden.

using System;

public class Word
{
    private string _text;
    private bool _isHidden;


// The key behaviors for the Word class are to hide and show a word and to check if a word is hidden or not. 
// In addition, a Word should have a behavior to get the display text of that word, which would be either 
// the word itself (for example, "prayer") or, if the word were hidden, this behavior would return underscores 
// (for example, "______").

    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }

    public void HideWord()
    {
        _isHidden = true;

    }

    public void Showword()
    {
        // example ___ loved my son
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
            return _isHidden ? new string('_', _text.Length) : _text;
            // string underscores = new string('_', 5); // Creates "_____"
            // so this will take the length of the word, and then make the underscores that long.
    }
    public string GetText()
    {
        return _text;
    }

}