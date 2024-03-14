class GoalManager {
    private int _totalPoints;
    private List<Goal> _goalList;
    public GoalManager() {
        _totalPoints = 0;
        _goalList = new List<Goal>();
    }

    public void NewGoal() {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("\nWhich type of goal would you like to create? ");
        string _goalChoice = Console.ReadLine();
        
        Console.WriteLine("What is the name of your goal?");
        string _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int _points = int.Parse(Console.ReadLine());
                 
        if (_goalChoice == "1") {
            SimpleGoal simpleGoal = new SimpleGoal(_name, _description, _points);
            _goalList.Add(simpleGoal);
        }
        else if (_goalChoice == "2") {
            EternalGoal eternalGoal = new EternalGoal(_name, _description, _points);
            _goalList.Add(eternalGoal);
        }
        else if (_goalChoice == "3") { 
            Console.WriteLine("How many times does this goal have to be accomplished for a bonus?");
            int _bonusPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int _bonusCompletions = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(_name, _description, _points, _bonusPoints, _bonusCompletions);
            _goalList.Add(checklistGoal);
        }
        else {
            Console.Write("Incorrect choice, press 'Enter' to return to the main menu.");
            Console.ReadLine();
        }
    }
    public void ViewGoals() {
        int i = 0;
        foreach (Goal goal in _goalList) {
            Console.Write($"{i += 1}. ");
            if (goal.IsComplete()) {
                Console.Write("[x] ");
            }
            else {
                Console.Write("[] ");
            }
            Console.Write($"{goal._name}: {goal._description}");
            if (goal is ChecklistGoal checklistGoal) {
                Console.Write($"Completed: {checklistGoal._timesComplete} / {checklistGoal._goalValue}");
            }
        }
        Console.WriteLine($"Total points: {_totalPoints}");   
    }
    public void WriteFile() {
        Console.WriteLine("Please enter a name for your file");
        string _fileName = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(_fileName)) {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _goalList) {
                if (goal is SimpleGoal simpleGoal) {
                    outputFile.WriteLine($"Simple:{simpleGoal._name}:{simpleGoal._description}:{simpleGoal._points}:{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal) {
                    outputFile.WriteLine($"Eternal:{eternalGoal._name}:{eternalGoal._description}:{eternalGoal._points}:{eternalGoal.IsComplete()}");
                }
                else if (goal is ChecklistGoal checklistGoal) {
                    outputFile.WriteLine($"Checklist:{checklistGoal._name}:{checklistGoal._description}:{checklistGoal._points}:{checklistGoal.IsComplete()}:{checklistGoal._bonusPoints}:{checklistGoal._bonusCompletions}");
                }
            }
        }
        Console.WriteLine("File saved. Press 'enter' to return to the menu");
        Console.ReadLine();

    }
    public void LoadFile() {
                Console.WriteLine("Please enter the name of the file you would like to load");
        string _fileName = Console.ReadLine() + ".txt";
        _goalList.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines) {
            //string[] parts = line.Split(":");
            //string _goalType = parts[0];
            //string _goalName = parts[1];
            //string _goalDescription = parts[2];
            //string _pointValue = parts[3];
            //string _complete = parts[4];
            //string _bonusPoints = parts[5];
            //string _bonusCompletions = parts[6];
        }
        Console.WriteLine("File loaded. Press 'enter' to return to the menu");
        Console.ReadLine();
        }
    public void AddPoints(int points) {
        _totalPoints += points;
    }
}