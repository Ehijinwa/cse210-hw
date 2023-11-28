public class Goal{
    protected bool _ischecked = false;
    protected string _name;
    protected string _type;
    protected string _description;
    protected int _points;
    public Goal(){

    }
    public virtual int forchecked()
    {
        if (_ischecked == false){
        _ischecked = true;
        return _points;
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
        Console.WriteLine($"{i}. {_name} ({_description})");
    }
    public virtual void PromptUser()
    {
        // Ask the user for their name
        Console.Write("what is the name of your goal? ");
        _name = Console.ReadLine();
        // Ask the user for the description of the goal
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        // Ask the user for points amount for this goal
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
}
