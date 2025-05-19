//  Exceeding Requirement: Added "Mood Rating" to each entry (scale 1–10)!!!

using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private int _moodRating; // support Mood Rating feature added...

    public Entry(string date, string promptText, string entryText, int moodRating)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _moodRating = moodRating; // for storing mood rating...
    }

    //  Save mood rating to file...
    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_moodRating}"; //  mood rating to file string added...
    }

    //  Load mood rating from file...
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        string date = parts[0];
        string prompt = parts[1];
        string entryText = parts[2];
        int mood = int.Parse(parts[3]); //  Parse mood rating...

        return new Entry(date, prompt, entryText, mood); //  Returning Entry with mood rating...
    }

    public void Display()
    {
        Console.WriteLine($"{_date}: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood Rating: {_moodRating}/10"); //  Displaying mood rating...
    }

    public string GetEntryDate()
    {
        return _date;
    }
}
