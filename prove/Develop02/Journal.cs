using System.Security.Cryptography.X509Certificates;

public class Journal {
    public List<string> _entries = new List<string>();
    Entry entry = new Entry();
    public void NewEntry() {
        string _prompt = entry.GetNextQuestion();
        Console.WriteLine(_prompt);
        string _userResponse = Console.ReadLine();
        string _date = entry._currentDate.ToString("MM/dd/yyyy");
        entry._formattedEntry = $"Date: {_date}, prompt: {_prompt}, Entry: {_userResponse}";
        _entries.Add(entry._formattedEntry);
    }
    public void ShowHistory() {
        foreach (string entry in _entries) {
            Console.WriteLine(entry);
        }
    }
    public void SaveFile() {

    }
    public void LoadFile() {
        
    }
}
