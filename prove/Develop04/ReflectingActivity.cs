class ReflectingActivity : Activity {
    private string _prompt;
    private List<string> _reflectPrompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {
        _reflectPrompts = new List<string>() {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>() {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void RunReflecting() {
        ActivityStart();
        GetReflectingPrompt();
    }
    public void GetReflectingPrompt() {
        Random _random = new Random();
        int _randomPrompt = _random.Next(_reflectPrompts.Count);
        _prompt = _reflectPrompts[_randomPrompt];
        Console.WriteLine(_prompt);
    }
    public void DisplayPrompt(string prompt) {

    }
    public void DisplayQuestion() {
        
    }
}