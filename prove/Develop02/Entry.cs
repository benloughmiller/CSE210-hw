public class Entry {
    public DateTime _currentDate = DateTime.Now;
    public string _formattedEntry = "";
    
    private List<string> questions = new List<string>() {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    };

    private int _questionCount = -1;

    public string GetNextQuestion() {
        _questionCount = _questionCount + 1;
        return questions[_questionCount];
    }
}
