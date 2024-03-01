using System.Reflection.Metadata.Ecma335;

class Activity {
private string _activityName;
private string _description;
private int _duration;

private List <string> _animation = new List<string>();
    public Activity(string name, string description) {
        _activityName = name;
        _description = description;

        _animation = new List<string>(){
            "|", "/", "—", "\\", "|", "/", "—", "\\"
        };
    }
    public void ActivityStart() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.\n");
        Console.WriteLine(_description);

    }
    public int GetDuration() {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        return _duration;
    }
    public void ActivityEnd() {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName} activity.");

    }
    public void CountdownTimer(int seconds) {
    for (int i = seconds; i > 0; i--) {
        Console.Write($"\b{i}");
        Thread.Sleep(1000);
    }
    Console.Write("\b \b");
    }
    public void SpinnyAnimation(int wait) {
        foreach (string s in _animation) {
            Console.Write("\b \b" + s);
            Thread.Sleep(wait);
        }
    }
}