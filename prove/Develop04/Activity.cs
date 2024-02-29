class Activity {
private string _activityName;
private string _description;
private int _duration;
    public Activity(string name, string description) {
        _activityName = name;
        _description = description;
    }
    public void ActivityStart() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void ActivityEnd() {
        
    }
    public void CountdownTimer(int seconds) {

    }
    public void TimeDelay(int seconds) {

    }
}