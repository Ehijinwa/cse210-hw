class Entry {
    public string _date;
    public string _prompt;
    public string _response;

    // Record the given date
    public void RecordDate(string date) {
        _date = date;
    }
    // Record the given prompt
    public void RecordPrompt(string prompt) {
        _prompt = prompt;
    }
    // Record the given response
    public void RecordReponse(string response) {
        _response = response;
    }

    
}