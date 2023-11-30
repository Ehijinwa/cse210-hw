public abstract class Goal {
    protected bool _ischecked = false;
    protected string _name;
    public string Name
    {
        get {return _name;}
        set {_name = value;}
    }
    protected string _description;
    public string Description
    {
        get {return _description;}
        set {_description = value;}
    }
    protected int _points;
    public int Points
    {
        get {return _points;}
        set {_points = value;}
    }
    public Goal(){

    }
    public virtual int forchecked()
    {
        if (_ischecked == false){
        _ischecked = true;
        return Points;
        }
        else {
            return 0;
        }
    }
    public virtual string checkname()
    {
        return "";
    }
    public virtual void Display(int i)
    {
        if (_ischecked)
        {
            Console.WriteLine($"[x] {i}. {Name} ({Description})");
        }
        else 
        {
            Console.WriteLine($"[ ] {i}. {Name} ({Description})");
        }
    }
    public virtual void PromptUser()
    {
        // Ask the user for their name
        Console.Write("what is the name of your goal? ");
        Name = Console.ReadLine();
        // Ask the user for the description of the goal
        Console.Write("What is a short description of it? ");
        Description = Console.ReadLine();
        // Ask the user for points amount for this goal
        Console.Write("What is the amount of points associated with this goal? ");
        Points = int.Parse(Console.ReadLine());
    }

    public abstract int RecordEvent();
}
