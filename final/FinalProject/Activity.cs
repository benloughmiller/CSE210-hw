using System.Reflection;

abstract class Activity {
    private string _name;
    private string _description;
    private int _result;
    private List <string> _animation = new List<string>();
    public Activity(string name, string description) {
        _name = name;
        _description = description;
        _animation = new List<string>() {
            "—", "\\", "|", "/", "—", "\\", "|", "/" 
        };
    }
    protected void RunActivity(int repetition, int maxRepitition) {
        int _repetition = repetition;
        if (_repetition == 1) {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity!");
            Console.WriteLine($"{_description}\n");
            Console.Write("Press 'Enter' to begin the activity: ");
            Console.ReadLine();
            Console.WriteLine();
        }
        CalcActivity();

        if (repetition == maxRepitition) {
            Console.Write("Finished the Activity. Press 'Enter' to return to the menu: ");
            Console.ReadLine();
        }
    }
    protected void SpinnyAnimation(int wait) {
        Console.CursorVisible = false;
        foreach (string s in _animation) {
            Console.Write(s);
            Thread.Sleep(wait);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;
    }
    protected int GetRandomNumber(int maximum) {
        Random random = new Random();
        int randomNumber = random.Next(1, maximum + 1);
        _result = randomNumber;
        return _result;
    }
    public int GetResult(){
        return _result;
    }
    protected abstract void CalcActivity();
    
}