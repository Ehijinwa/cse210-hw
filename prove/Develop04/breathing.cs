public class Breathing : Activity
{
    public Breathing()
    {
        _activityName = "Breathing Activity";
        _instruction = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }
    public void DoBreathingActivity()
    {
        Anime(2);

        DateTime time = DateTime.Now;
        while(DateTime.Now < time.AddSeconds(_second))
        {
            Console.WriteLine("Breathe in ");
            Counttime(5);
            Console.WriteLine("Now Breathe Out ");
            Counttime(5);

        }
        
        Console.WriteLine("Well done");
        Anime(2);
        Console.WriteLine($"You have completed another {_second} seconds of the breathing activity");
        Anime(2);
    }
}