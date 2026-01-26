using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");    // Fixed label
        Console.WriteLine($"Entry: {_entryText}");      // Fixed label
        Console.WriteLine();
    }
}