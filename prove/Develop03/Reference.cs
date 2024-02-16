class Reference {
    Scripture scripture = new Scripture();
    private List<string> _refs = new List<string>();
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference() {
        _refs = new List<string>() {
            "Proverbs 3:5-6",
            "John 3:16"
        };
    }
    public string ConvertReference() {
        //Gets a random reference from the list, then splits it piece by piece into variables 
        //If the program finds a verse range, it will print the range. Otherwise it will print the single verse
        string[] _ref = _refs[scripture.RandomNumber()].Split(' ');
        _book = _ref[0];

        string[] _chapterVerse = _ref[1].Split(':');
        _chapter = int.Parse(_chapterVerse[0]);

        string[] _verse = _chapterVerse[1].Split('-');
        _startVerse = int.Parse(_verse[0]);

        if (_verse.Length > 1) {
            _endVerse = int.Parse(_verse[1]);

            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
            return $"{_book} {_chapter}:{_startVerse}";
        }

    }
}
    
