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

        //For each word in the verse, if the word is hidden, display the word with each individual letter replaced by underscores
        foreach (Word word in _words) {
            if (word.IsHidden()) {
                string _hiddenWord = "";
            
                foreach (char c in word.GetWord()) {
                    _hiddenWord += "_";
                }
                Console.Write($"{_hiddenWord} ");  
            }
            else {
                Console.Write($"{word.GetWord()} ");
            }
        }

    }
    public void HideWord(int _difficulty) {
        //removes whichever is less, the difficulty level or the number of words left in the verse
        int _wordsToRemove = Math.Min(_difficulty, _words.Count);
        
        //For every integer in the range of wordsToRemove, hide a word
        for (int i = 0; i < _wordsToRemove; i++) { 
            int _randomNumber = _random.Next(_words.Count);

        //If the word is already hidden, try a different word    
            while (_words[_randomNumber].IsHidden())
            {
                _randomNumber = _random.Next(_words.Count);
            }
            _words[_randomNumber].HideWord();
        }
    }
}