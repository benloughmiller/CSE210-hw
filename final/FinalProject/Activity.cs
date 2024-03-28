abstract class Activity {
    private string _name;
    private string _description;
    private List <string> _animation = new List<string>();
    public Activity(string name, string description) {
        _name = name;
        _description = description;
        _animation = new List<string>() {
            "—", "\\", "|", "/", "—", "\\", "|", "/" 
        };
    }
    protected void ActivityStart() {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);

    }
    protected int GetRandomNumber(int maximum) {
        Random _random = new Random();
        int _randomNumber = _random.Next(1, maximum + 1);
        return _randomNumber;

    }
    protected void SpinnyAnimation(int wait) {
        foreach (string s in _animation) {
            Console.Write(s);
            Thread.Sleep(wait);
            Console.Write("\b \b");
        }

    }
    public abstract void RunActivity();
}