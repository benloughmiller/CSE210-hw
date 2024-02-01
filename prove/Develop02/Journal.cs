public class Journal {
    private Entry entry;
    public List<Entry> entries;
    public Journal() {
        entry = new Entry();
        entries = new List<Entry>();
    }

    public void NewEntry() {
        string prompt = entry.GetNextQuestion();
        Console.WriteLine(prompt);
        string  _userResponse = Console.ReadLine();
    }
    public void ShowHistory() {
        
    }
    public void SaveFile() {

    }
    public void LoadFile() {
        
    }
}
