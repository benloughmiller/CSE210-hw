class Scripture {
    Reference Reference = new Reference();
    public List<string> _conVerse = new List<string>();
    public Scripture() {

    }
    
    public void Convert() {
        (string _reference, string _verse) = Reference.GetNextVerse();
        Console.WriteLine($"Reference: {_reference}");
        Console.WriteLine($"Verse: {_verse}");
    } 
}  