using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool running  = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Enter your selection? ");

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
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                running = false;
            }

        }
    }
}