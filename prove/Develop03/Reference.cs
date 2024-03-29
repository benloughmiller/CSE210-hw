class Reference {
    private List<string> _refs = new List<string>();
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    //_randomNumber is left public. I could not think of a way to have the same random number be used in both the Reference and Scripture classes using the constructor itself.
    public int _randomNumber;
    private Random _random = new Random();

    public Reference() {
        // List of references
        _refs = new List<string>() {
            "Proverbs 3:5-6",
            "John 3:16",
            "Alma 7:11",
            "Esther 8:9",
            "John 11:35"
        };
    }

    public void RandomVerse() {
        // Returns a random number between 0 and the number of references in the list. This number will be used to select the coordinating verse
        _randomNumber = _random.Next(_refs.Count);
    }

    public string GetReference() {
        // Gets a random verse from the list of references, fills variables, and returns the reference
        string[] _ref = _refs[_randomNumber].Split(' ');

        _book = _ref[0];
        string[] _chapterVerse = _ref[1].Split(':');
        _chapter = int.Parse(_chapterVerse[0]);
        string[] _verse = _chapterVerse[1].Split('-');
        _startVerse = int.Parse(_verse[0]);

        if (_verse.Length > 1) {
            _endVerse = int.Parse(_verse[1]);
        }
        else {
            _endVerse = null;
        }

        if (_endVerse != null) {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}, ";
        }
        else {
            return $"{_book} {_chapter}:{_startVerse}, ";
        }
    }
}
