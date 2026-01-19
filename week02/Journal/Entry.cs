using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Date: {_promptText}");
        Console.WriteLine($"Date: {_entryText}");
        Console.WriteLine();       
    }
}