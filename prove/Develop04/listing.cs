public class Listing:Activity
{
    public Listing() 
    {
        _activityName = "Listing Activity";
        _instruction = "his activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }    
    private string _entrylist;
    private List<string> random2 = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public string forlists(){
        int size = random2.Count;
        Random L = new Random();
        int RandomIndex = L.Next(size);
        string listsprompt = random2[RandomIndex];
        Console.WriteLine(listsprompt);
        return listsprompt;
    }
    public void DisplayTodo()
    {
        int _entrylist = 0;
        Anime(3);
        Console.WriteLine("List as many responses you can to the following prompt ");
        forlists();
        Console.WriteLine("You may begin in");
        Counttime(4);
        DateTime time = DateTime.Now;
        while(DateTime.Now < time.AddSeconds(_second))
        {
            Console.ReadLine();
            _entrylist += 1;
        }
        Console.WriteLine($"You listed {_entrylist} items");
        Console.WriteLine("Well done!!");
        Anime(3);
        Console.WriteLine($"You have completed another {_second}of the Listing Activity.");
        Anime(3);
    }

}