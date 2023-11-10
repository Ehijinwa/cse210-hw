using System;
using System.Runtime.CompilerServices;

// Foundation. Start programming here. Main stem of a plant
class Program
{
    static void Main(string[] args)
    {
        // Display the main menu, and get the user's choice.
        Console.Clear();
        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            // Interpret the user's choice 
            if (choice == "1") 
            {
                // Start the breathing activity
                Console.Clear(); // Clear the console in preparation
                
                // Create a breathing activity object
                Breathing breathing = new Breathing(); // object
                breathing.DisplayWelcome(); // display welcome message
                Console.WriteLine(); // empty newline
                breathing.DisplayDescription(); // display description of activity
                Console.WriteLine(); // empty newline
                breathing.GetSeconds();
                Console.Clear();
                breathing.DoBreathingActivity();
            }
            else if (choice == "2")
            {
                // Start the reflecting activity
                Reflecting reflecting = new Reflecting(); // object
                reflecting.DisplayWelcome();
                Console.WriteLine(); // empty newline
                reflecting.DisplayDescription(); // display description of activity
                Console.WriteLine(); // empty newline
                reflecting.GetSeconds();
                Console.Clear();
                reflecting.DoReflectingActivity();
            }
            else if (choice == "3")
            {
                // Starting the listing activity
                Listing listing = new Listing(); // object
                listing.DisplayWelcome();
                Console.WriteLine(); // empty newline
                listing.DisplayDescription(); // display description of activity
                Console.WriteLine(); // empty newline
                listing.GetSeconds();
                Console.Clear();
                listing.DisplayTodo();
            }
        }
    }
}