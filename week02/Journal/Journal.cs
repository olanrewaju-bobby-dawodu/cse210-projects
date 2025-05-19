// Exceeding Requirement: Save/load mood rating with journal entries...

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Save mood rating to file...
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString()); // Save entry with mood rating...
            }
        }
    }

    //  Load mood rating from file...
    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Entry entry = Entry.FromFileString(line); //Load entry with mood rating...
                _entries.Add(entry);
            }
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); //  Displaying entry with mood rating...
            Console.WriteLine(); // space between entries added...
        }
    }
}
