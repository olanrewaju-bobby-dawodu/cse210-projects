using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        // Spliting text into words and creating Word objects...
        string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string w in wordArray)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        scriptureText = scriptureText.TrimEnd();
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
