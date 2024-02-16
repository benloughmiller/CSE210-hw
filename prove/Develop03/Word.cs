class Word {
    private bool _hidden;
    private string _word;

    public Word(string word) {
        _word = word;
        _hidden = false;
    }

    public string GetWord() {
        return _word;
    }
    public bool IsHidden() {
            return _hidden;
    }
}
