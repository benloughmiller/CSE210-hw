abstract class Activity {
    private string _name;
    private string _description;
    public Activity(string name, string description) {
        _name = name;
        _description = description;

    }
    protected void ActivityStart() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);

    }
    protected int GetRandomNumber(int maximum) {
        Random _random = new Random();
        int _randomNumber = _random.Next(1, maximum + 1);
        return _randomNumber;

    }
    public abstract void RunActivity(int repetition);
}