using System.Security.Cryptography.X509Certificates;

public class Simple:Goal
{
    public Simple()
    {
        // this._ischecked = _ischecked;
    }
    public override void Display(int i)
    {
        if (_ischecked)
        {
            Console.WriteLine("The goals are");
            Console.WriteLine($"{i} [x] {_name} {_type}");
            Console.WriteLine($"You have {_points}");
        }
        else 
        {
            Console.WriteLine("The goals are");
            Console.WriteLine($"{i} [x] {_name} {_type}");
        }
    }
    public override string checkname()
    {
        return $"{_name} {_type} {_points} {_ischecked}";
    }
}