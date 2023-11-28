public class CheckListGoal : Goal {
    protected int _repetitions;
    protected int _bonusPoints;
    public override void PromptUser()
    {
        base.PromptUser(); // Do everything the base function does
        // and then do some more.
        // Prompt for repetitions
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _repetitions = int.Parse(Console.ReadLine());
        // Prompt for bonus points
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
}
