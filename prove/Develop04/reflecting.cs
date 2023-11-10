public class Reflecting:Activity
{
    private List<string> _prompts = new List<string>() {
        "Think of a time when you did something really difficult.",
        "Think of a time when you did not go to church.",
        "Think of a time when you were wicked.",
        "Think of a time when you were scrolling on your phone.",
        "Think of a time when you wanted to hit your brother."
    };
    private List<string> _promts2 = new List<string>()
     {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?."
    };
    public string forprompts(){
        int size = _prompts.Count;
        Random R = new Random();
        int RandomIndex = R.Next(size);
        string randomprompt = _prompts[RandomIndex];
        Console.WriteLine(randomprompt);
        return randomprompt;
    }
    public string tworand()
    {
        int size = _promts2.Count;
        Random RR = new Random();
        int RandomIndex = RR.Next(size);
        string randpromptss = _promts2[RandomIndex];
        Console.WriteLine(randpromptss);
        return randpromptss;

    }
    public Reflecting ()
    {
        _activityName = "Reflecting Activity";
        _instruction = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
    }    

    public void DoReflectingActivity()
    {
        
        Console.WriteLine("Get ready");
        Anime(4);

        Console.WriteLine("Consider the following prompt:\n");

        Console.WriteLine();
        forprompts();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to the experience.");
        DateTime time = DateTime.Now;
        while(DateTime.Now < time.AddSeconds(_second))
        {
            Console.WriteLine("You may begin in: ");
            Counttime(3);
            tworand();
            Anime(4);
            tworand();
            Anime(3);
        }
        Console.Clear();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_second} seconds of the Reflecting Activity");


        
    }

}