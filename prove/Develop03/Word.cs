
class Word {
    private bool _hidden;
    private string _word;

    public Word(string word) {
        //Sets each word in the list and sets it to not hidden
        _word = word;
        _hidden = false;
    }

    public string GetWord() {
        return _word;
    }
    public void HideWord() {
        //Hides the word
        _hidden = true;
    }

    public bool IsHidden() {
        //Tells whether the word is hidden or not
        return _hidden;
    }
}
