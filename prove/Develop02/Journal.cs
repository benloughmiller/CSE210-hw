using System.IO; 

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
        Console.WriteLine("Please enter a name for your file");
        string _fileName = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(_fileName)) {
            foreach (string entry in _entries) {
            outputFile.WriteLine(entry);
            }
        Console.WriteLine("File saved");
        }
    }
    public void LoadFile() {
        Console.WriteLine("Please enter the name of the file you would like to load");
        string _filename = Console.ReadLine() + ".txt";
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines) {
         _entries.Add(line);
        }
        Console.WriteLine("File loaded");
    }
    public void DeleteFile() {
    Console.WriteLine("Please enter the name of the file you would like to delete");
    string _filename = Console.ReadLine() + ".txt";
    System.IO.File.Delete(_filename);
    Console.WriteLine("File deleted");
    }
}

