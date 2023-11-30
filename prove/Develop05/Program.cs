using System;
using System.ComponentModel.Design;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints;
    static void Main(string[] args)
    {
        Console.Clear(); // clear the terminal
        bool running = true;
        while(running) {
            Console.WriteLine($"Total points: {totalPoints}\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();

            // Create a new goal
            if (response == "1")
            {
                // create new goal
                // Ask the user what type of goal they would like to create
                Console.WriteLine("The type of goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("What type of goal will you like to create? ");
                string response2 = Console.ReadLine();
                if (response2 == "1"){
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.PromptUser();
                    goals.Add(simpleGoal);
                }
                else if (response2 == "2"){
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.PromptUser();
                    goals.Add(eternalGoal);
                }
                else if (response2 == "3"){
                    CheckListGoal checklistgoal = new CheckListGoal();
                    checklistgoal.PromptUser();
                    goals.Add(checklistgoal);
                }

            }
            // List Goals
            else if (response == "2")
            {
                // List Goals
                int counter = 0;
                Console.WriteLine("The goals are:");
                foreach(Goal goal in goals)
                {
                    counter ++;
                    goal.Display(counter);
                }
            }
            // Save Goals
            else if (response == "3")
            {
                // save goals
                SaveGoals();
            }
            // Load Goals
            else if (response == "4")
            {
                // Load goals 
                LoadGoals();
            }
            // Record Event
            else if (response == "5")
            {
                // List out all the goals for the user to see
                DisplayGoals();
                // Ask the user which goal they accomplished
                Console.Write("Which goal did you accomplish? ");
                string response3 = Console.ReadLine();
                // Take the goal out
                int i = int.Parse(response3) - 1;
                Goal goal = goals[i];
                // Mark the goal as complete and add the points to totalPoints
                int newPoints = goal.RecordEvent();
                totalPoints += newPoints;
                Console.WriteLine($"Congratulations you have earned {newPoints} points!");
                Console.WriteLine($"You now have {totalPoints} points.");
            }
            else if (response == "6")
            {
                //quit
                running = false;
            }
        }
    }

    static void SaveGoals()
    {
        // Display the prompt
        Console.Write("What is the filename of the goal file? ");
        // Get the filename input from the user
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine($"TotalPoints,{totalPoints}");
            // You can add text to the file with the WriteLine method
            foreach(Goal goal in goals)
            {
                if (goal.GetType().ToString() != "CheckListGoal")
                {
                    // For simple and eternal goals
                    outputFile.WriteLine($"{goal.GetType()},{goal.Name},{goal.Description},{goal.Points}");
                }
                else
                {
                    // For checklist goals
                    outputFile.WriteLine(goal.ToString());
                }
            }
        }
        
    }

    static void LoadGoals()
    {
        // Display the prompt
        Console.Write("What is the filename of the goal file? ");
        // Get the filename input from the user
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Split the line into its separate parts
            string[] parts = line.Split(",");

            if (parts[0] == "TotalPoints")
            {
                totalPoints = int.Parse(parts[1]);
            }
            else
            {
                // Split up the line into variables
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                // Create new Goal objects
                if (type == "SimpleGoal")
                {
                    SimpleGoal goal = new SimpleGoal();
                    // Copy the values over into the new goal
                    goal.Name = name;
                    goal.Description = description;
                    goal.Points = points;

                    // Add the new goal to the list of goals
                    goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal goal = new EternalGoal();
                    // Copy the values over into the new goal
                    goal.Name = name;
                    goal.Description = description;
                    goal.Points = points;

                    // Add the new goal to the list of goals
                    goals.Add(goal);
                }
                else if (type == "CheckListGoal")
                {
                    // These variables are unique to Checklistgoal
                    int completedReps = int.Parse(parts[4]);
                    int repsRequired = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);

                    // Copy the values over into the new goal
                    CheckListGoal goal = new CheckListGoal();
                    goal.Name = name;
                    goal.Description = description;
                    goal.Points = points;
                    goal.CompletedReps = completedReps;
                    goal.RepsRequired = repsRequired;
                    goal.BonusPoints = bonusPoints;

                    // Add the new goal to the list of goals
                    goals.Add(goal);
                }
            }

        }
    }
    static void DisplayGoals()
    {
        Console.WriteLine("The goals are");
        int counter = 0;
        // Foreach loop. Does something a specified number of times
        foreach(Goal goal in goals)
        {
            counter ++;
            Console.WriteLine($"{counter}. {goal.Name}"); 
        }
    }
}