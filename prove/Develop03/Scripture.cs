
class Scripture {
    Reference reference = new Reference();
    private Random _random = new Random();
    private List<string> _verses = new List<string>();
    public List<string> _words = new List<string>();
    private string _reference;
    private string _verse;
    public Scripture() {
        _verses = new List<string>(){
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways aacknowledge him, and he shall direct thy paths.",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        };
        _reference = reference.ConvertReference();
        _verse = _verses[RandomNumber()];
        string [] _verseWords = _verse.Split(' ');
        foreach (string word in _verseWords) {
            _words.Add(word);
        }
        
    }
    public void DisplayVerse() {
        Console.WriteLine(_reference);
        foreach (string word in _words) {
        Console.Write($"{word} ");
        }
        

    }
    public int RandomNumber() {
    //Returns a random number between 0 and the number of references in the list
    int _randomNumber = _random.Next(_verses.Count);
    return _randomNumber;
    }
}
