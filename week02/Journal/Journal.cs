using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal saved to '{file}' successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }
    
    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear();
            
            if (!File.Exists(file))
            {
                Console.WriteLine("File not found.");
                return;
            }
            
            string[] lines = File.ReadAllLines(file);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                
                if (parts.Length == 3)
                {
                    Entry loadedEntry = new Entry();
                    loadedEntry._date = parts[0];
                    loadedEntry._promptText = parts[1];
                    loadedEntry._entryText = parts[2];
                    
                    _entries.Add(loadedEntry);
                }
                else
                {
                    Console.WriteLine($"Skipping invalid line: {line}");
                }
            }
            Console.WriteLine($"Loaded {_entries.Count} entries.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
    
    // EXTRA FEATURE: Search entries by keyword
    public void SearchEntries(string keyword)
    {
        bool found = false;
        
        foreach (Entry entry in _entries)
        {
            if (entry._entryText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry._promptText.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
                found = true;
            }
        }
        
        if (!found)
        {
            Console.WriteLine($"No entries found containing '{keyword}'.");
        }
    }
}