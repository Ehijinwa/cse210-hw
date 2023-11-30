public class CheckListGoal : Goal {
    protected int _completedReps;
    public int CompletedReps
    {
        get {return _completedReps;}
        set {_completedReps = value;}
    }
    protected int _repsRequired;
    public int RepsRequired
    {
        get {return _repsRequired;}
        set {_repsRequired = value;}
    }
    protected int _bonusPoints;
    public int BonusPoints
    {
        get {return _bonusPoints;}
        set {_bonusPoints = value;}
    }
    public override void PromptUser()
    {
        base.PromptUser(); // Do everything the base function does
        // and then do some more.
        // Prompt for repetitions
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _repsRequired = int.Parse(Console.ReadLine());
        // Prompt for bonus points
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    

    public override string ToString()
    {
        return $"{GetType()},{Name},{Description},{Points},{CompletedReps},{RepsRequired},{BonusPoints}";
    }

    public override int RecordEvent()
    {
        _completedReps ++;

        if (_completedReps == _repsRequired)
        {
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override void Display(int i)
    {
        if(_ischecked)
        {
            Console.WriteLine($"[x] {i}. {Name} ({Description}) -- currently completed: {_completedReps}/{_repsRequired}");
        }
        else
        {
            Console.WriteLine($"[ ] {i}. {Name} ({Description}) -- currently completed: {_completedReps}/{_repsRequired}");

        }
    }
}