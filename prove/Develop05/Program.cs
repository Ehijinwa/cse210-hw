using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        bool running = true;
        while(running){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        string response = Console.ReadLine();

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
                Simple simpleGoal = new Simple();
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
        else if (response == "2")
        {
            // List Goals
            int i =0;
            foreach(Goal goal in goals){
                i++;
                goal.Display(i);
            }
        }
        else if (response == "3")
        {
            // save goals
        }
        else if (response == "4")
        {
            // Load goals 
        }
        else if (response == "5")
        {
            //record event
        }
        else if (response == "6")
        {
            //quit
            running = false;
        }


    }
    }
}