using System.Reflection;

abstract class Activity {
    private string _name;
    private string _description;
    private int _result;
    private int _maximum;
    public Activity(string name, string description) {
        _name = name;
        _description = description;

    }
    protected void ActivityStart() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
    }
    protected void ActivityEnd() {
    }
    protected int GetRandomNumber(int maximum) {
        Random _random = new Random();
        _maximum = maximum;
        int _randomNumber = _random.Next(1, _maximum + 1);
        _result = _randomNumber;
        return _result;
    }
    public int GetResult(){
        return _result;
    }
    public int GetMaximum() {
        return _maximum;
    }
    public abstract void RunActivity(int repetition);
    
}