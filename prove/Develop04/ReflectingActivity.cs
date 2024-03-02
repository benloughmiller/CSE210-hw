class ReflectingActivity : Activity {
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
        int _activityTime = GetDuration();

        Console.WriteLine("Consider the following prompt:\n");
        GetReflectingPrompt();
        Console.WriteLine("\nWhen you have something in mind, press 'Enter' to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountdownTimer(5);
        Console.Clear();
        DisplayQuestions(_activityTime);
        ActivityEnd();
    }
    private void GetReflectingPrompt() {
        Random _random = new Random();
        int _randomPrompt = _random.Next(_reflectPrompts.Count);
        string _displayPrompt = "---- " + _reflectPrompts[_randomPrompt] + " ----";
        Console.WriteLine(_displayPrompt);
    }

    private string GetQuestion() {
        Random _random = new Random();
        int _randomQuestion = _random.Next(_questions.Count);
        string _displayQuestion = _questions[_randomQuestion];
        _questions.RemoveAt(_randomQuestion);
        return _displayQuestion;
    }
    private void DisplayQuestions(int time) {
        int _remainingTime = time; 
        while (_remainingTime > 0) {

            if (_remainingTime >= 10) {
               Console.Write($"> {GetQuestion()} ");
                SpinnyAnimation(1000);
                Console.WriteLine();
                _remainingTime -= 10;
            }
            else {
                Console.Write($"> {GetQuestion()} ");
                SpinnyAnimation(100 * _remainingTime);
                Console.WriteLine();
                _remainingTime = 0;  
            }
        }
        Console.WriteLine();
    }
}