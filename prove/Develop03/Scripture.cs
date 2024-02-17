class Scripture {

    Reference reference = new Reference();
    private Random _random = new Random();
    private List<string> _verses = new List<string>();
    private List<Word> _words = new List<Word>();
    private string _reference;

    public Scripture() {
        _verses = new List<string>(){
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.",
            "Then were the king's scribes called at that time in the third month, that is, the month Sivan, on the three and twentieth day thereof; and it was written according to all that Mordecai commanded unto the Jews, and to the lieutenants, and the deputies and rulers of the provinces which are from India unto Ethiopia, an hundred twenty and seven provinces, unto every province according to the writing thereof, and unto every people after their language, and to the Jews according to their writing, and according to their language.",
            "Jesus Wept."       
        };
        reference.RandomVerse();
        _reference = reference.GetReference();

        string[] _verseWords = _verses[reference._randomNumber].Split(' ');
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
        AllHidden();
    }
    public void HideWord(int _difficulty) {
        //removes whichever is less, the difficulty level or the number of words left in the verse
        int _wordsToRemove = Math.Min(_difficulty, _words.Count(word => !word.IsHidden()));
        
        //For every integer in the range of wordsToRemove, hide a word
        for (int i = 0; i < _wordsToRemove; i++) { 
            int _randomNumber = _random.Next(_words.Count);

        //If the word is already hidden, try a different word    
            while (_words[_randomNumber].IsHidden()) {
                _randomNumber = _random.Next(_words.Count);
            }
            _words[_randomNumber].HideWord();
        }
    }
    public void AllHidden() {
        //If all the words are hidden, display the verse
        if (_words.All(word => word.IsHidden())) {
            Console.Clear();
            Console.WriteLine("There are no more remaining words. Do you remember the verse?");
            Console.WriteLine("Presss 'Enter' to exit the program");
            Console.ReadLine();
            Environment.Exit(0);
        }    
    }
}