using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    public override void Display(int i)
    {
        if (_ischecked)
        {
            // This condition is for if the goal is complete, or checked
            Console.WriteLine($"[x] {i}. {Name} ({Description})");
        }
        else 
        {
            // This conditino is for if the goal is incomplete, or unchecked
            Console.WriteLine($"[ ] {i}. {Name} ({Description})");
        }
    }
    public override int RecordEvent()
    {
        if (_ischecked)
        {
            return 0;
        }
        else
        {
            _ischecked = true;
            return Points;
        }
    }


    public override string checkname()
    {
        return $"{Name} {Points} {_ischecked}";
    }
}