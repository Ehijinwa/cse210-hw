using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "4";
        
        journal.Display();
        
         while (choice != "5")
         {
            Console.WriteLine("Main Menu (select 5 or type quit to exit)");
            Console.WriteLine("    1. Add Entry");
            Console.WriteLine("    2. Display Entries");
            Console.WriteLine("    3. Save to File");
            Console.WriteLine("    4. Load Entries from File");
            Console.WriteLine("    5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1") 
            {
                string prompt = journal.GetPrompt();
                Console.WriteLine(prompt);
                journal.AddEntry(prompt,journal.GetResponse());
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                LoadAndWrite.SaveEntriesToFile(journal.Entries);
            }
            else if (choice == "4")
            {
                journal.Entries = LoadAndWrite.ReadEntriesFromFile();
            }
            else if (choice == "5" || choice == "quit")
            {
                break;
            }
         }
    }

}
