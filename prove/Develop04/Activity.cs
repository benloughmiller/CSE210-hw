class Activity {
private string _activityName;
private string _description;
private int _duration;
private bool _validDuration = false;

private List <string> _animation = new List<string>();
    public Activity(string name, string description) {
        _activityName = name;
        _description = description;

        _animation = new List<string>() {
            "|", "/", "—", "\\", "|", "/", "—", "\\"
        };
    }
    public void ActivityStart() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.\n");
        Console.WriteLine(_description);
    }
    public void ActivityEnd() {
        Console.WriteLine("Well done!!");
        SpinnyAnimation(300);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName} activity.");
        SpinnyAnimation(300);
        Console.Write("Press 'Enter' to return to the menu.");
        Console.ReadLine();
    }
    public int GetDuration() {
        while (_validDuration != true) {
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            if (int.TryParse(Console.ReadLine(), out _duration)) {
                _validDuration = true;
            }
            else {
                Console.WriteLine("Invalid input, please enter a number.");
            }
        }   
        Console.Clear();
        Console.WriteLine("Get Ready...");
        SpinnyAnimation(300);
        Console.WriteLine();
        return _duration;
    }
    public void CountdownTimer(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void SpinnyAnimation(int wait) {
        foreach (string s in _animation) {
            Console.Write(s);
            Thread.Sleep(wait);
            Console.Write("\b \b");
        }

    }
}