using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using var ouputFile = new StreamWriter(filename);
        foreach (var entry in _entries)
        {
            ouputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry entry = new Entry()
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            AddEntry(entry);
        };
    }
}