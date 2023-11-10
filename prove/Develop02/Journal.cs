class Journal {
    List<string> _prompts;
    List<Entry> _entries;

    // Constructor is automatically called whenever you create a new 
    // instance of this class (or a new Journal, in this case)
    public Journal() {
        // Create a new list
        _prompts = new List<string>();
        _entries = new List<Entry>();
        // Add 5 prompts to the list
        _prompts.Add("What did you do today?");
        _prompts.Add("What did you eat today?");
        _prompts.Add("What was the most interesting thing you did today?");
        _prompts.Add("What was the weather like today?");
        _prompts.Add("How many assignments did you have today?");
    }

    public string GetPrompt() {
        // Create a random object from the Random class
        Random rand = new Random();
        // Get the length of the list of prompts
        int lengthOfList = _prompts.Count; 
        // Get a random number between 0 and the length of the list
        int randomNumber = rand.Next(lengthOfList); 
        // Get the prompt associated with the random number which we chose
        string prompt = _prompts[randomNumber];
        
        // Return the random prompt
        return prompt;
    }
}