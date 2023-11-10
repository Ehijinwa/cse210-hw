public class Activity {
    protected string _activityName;
    protected string _instruction;
    protected string _inputBreathing;
    protected int _second;

    public void DisplayWelcome() 
    {
        Console.WriteLine($"Welcome to the {_activityName}");
    }
    public void DisplayDescription()
    {
        Console.WriteLine($"{_instruction}");
    }

    public void GetSeconds()
    {
        Console.Write("How long, in seconds would you like the session to last? ");
        _second = int.Parse(Console.ReadLine());
    }

    public void Anime(int ilong)
    {
        for (int i = 0; i < ilong; i ++)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        

    }
    public void Counttime(int time)
    {
        for (int i = time; i > 0; i --)
        {
            Console.Write ("\b \b");
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
        Console.Write ("\b \b");
    }
}
