public class Scripture{
    private string _scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
    private List <Word> _words = new List <Word> ();
    private List <int> numbers = new List <int> ();
    public Scripture (){
        string[]words = _scripture.Split(" ");
        int count = 0;
        foreach (string word in words)
        {
            _words.Add(new Word(word));
            numbers.Add(count);
            count +=1;
        }
    }
    public bool Construct() {
        return numbers.Count > 0;
    }

    public void Identityword () 
    {
        int size = numbers.Count;
        Random R = new Random();
        int IndexRam = R.Next(size);
        
        if (numbers.Count!=0) 
        {
            _words[numbers[IndexRam]]= new Word ("__");
            numbers.RemoveAt(IndexRam);
        }
    }
    public void Display() {
        Console.WriteLine();
        foreach (Word word in _words){
            word.Display();
        }
    }
}