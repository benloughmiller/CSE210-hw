class Reference {
    private List<string> verses;
    private List<string> refs;
    Random _random = new Random();

    public Reference() {
        verses = new List<string>() {
            //Verses 2b added
            "Ben"
        };

        refs = new List<string>() {
            //References 2b added
            "Loughmiller"
        };
    }

    public (string Reference, string Verse) GetNextVerse() {
        int _randomVerse = _random.Next(verses.Count);
        return (refs[_randomVerse], verses[_randomVerse]);
    }
}
