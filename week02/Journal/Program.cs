/*
EXTRA FEATURE ADDED:
- Search Functionality: Users can search journal entries by keyword.
  The search checks both the prompt text and entry text (case-insensitive).
- Improved file handling with error catching and delimiter-based formatting.
- Enhanced user feedback with confirmation messages.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== Journal Menu ===");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");   // New option
            Console.WriteLine("6. Quit");
            Console.Write("Enter your selection: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry();

                DateTime currentTime = DateTime.Now;
                newEntry._date = currentTime.ToShortDateString();
                newEntry._promptText = promptGen.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry saved!");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved.");
            }
            else if (choice == "5")  // NEW SEARCH FEATURE
            {
                Console.Write("Enter keyword to search: ");
                string keyword = Console.ReadLine();
                journal.SearchEntries(keyword);
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}