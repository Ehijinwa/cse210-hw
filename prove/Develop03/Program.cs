using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("bible", 3, 16);
        Scripture scripture = new Scripture();
        
        string step = "";
        while (step == "" && scripture.Construct())
        {
            if (step!="Quit")
        {
            reference.display();
            scripture.Display();
            scripture.Identityword();   
            step = Console.ReadLine();
            Console.Clear();
        }
        else 
        {
            step = "Quit";
        }
        }
    }
}