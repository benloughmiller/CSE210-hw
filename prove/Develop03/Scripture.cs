class Scripture {

    private Random _random = new Random();
    Reference reference = new Reference();

    private List<string> _verses = new List<string>();
    private List<Word> _words = new List<Word>();
    private string _reference;

    public Scripture() {
        _verses = new List<string>(){
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        };
        _reference = reference.GetReference();
        string[] _verseWords = _verses[reference.RandomVerse()].Split(' ');
        foreach (string word in _verseWords) {
            _words.Add(new Word(word));
        }
        
    }
    public void DisplayVerse() {
        Console.WriteLine(_reference);
        foreach (Word word in _words) {
        Console.Write($"{word.GetWord()} ");
        }
    }

}
