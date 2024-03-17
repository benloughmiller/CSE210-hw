class GoalManager {
    private int _totalPoints;
    private int _earnedPoints;
    private List<Goal> _goalList;
    public GoalManager() {
        _totalPoints = 0;
        _earnedPoints = 0;
        _goalList = new List<Goal>();
    }

    public void NewGoal() {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.WriteLine("    4. Bad Habit Goal");
        Console.Write("Which type of goal would you like to create? ");
        string _goalChoice = Console.ReadLine();
        while (_goalChoice != "1" && _goalChoice != "2" && _goalChoice != "3" && _goalChoice != "4") {
            Console.Write("Incorrect Choice. Please enter a valid entry.");
            _goalChoice = Console.ReadLine();
        }
        Console.Write("What is the name of your goal?");
        string _name = Console.ReadLine();
        Console.Write("What is a short description of it?");
        string _description = Console.ReadLine();
    
        if (_goalChoice == "1") {
            Console.Write("What is the amount of points associated with this goal?");
            int _points = int.Parse(Console.ReadLine());
            _goalList.Add(new SimpleGoal(_name, _description, _points, false));

        }
        else if (_goalChoice == "2") {
            Console.Write("What is the amount of points associated with this goal?");
            int _points = int.Parse(Console.ReadLine());
            _goalList.Add(new EternalGoal(_name, _description, _points, false));
        }
        else if (_goalChoice == "3") {
            Console.Write("What is the amount of points associated with this goal?");
            int _points = int.Parse(Console.ReadLine()); 
            Console.Write("How many times does this goal have to be accomplished for a bonus?");
            int _bonusCompletions = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?");
            int _bonusPoints = int.Parse(Console.ReadLine());
            _goalList.Add(new ChecklistGoal(_name, _description, _points, false, _bonusPoints, _bonusCompletions, 0));
        }
        else if (_goalChoice == "4") {
            Console.Write("How many points should be lost each time this goal is recorded?");
            int _points = int.Parse(Console.ReadLine());
            _goalList.Add(new BadGoal(_name, _description, _points, false));
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
            Console.Write($"{goal.GetName()} ({goal.GetDescription()})");
            if (goal is ChecklistGoal checklistGoal) {
                Console.Write($" --- Currently completed: {checklistGoal.GetTimesComplete()}/{checklistGoal.GetGoalValue()}");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\nTotal points: {_totalPoints}");
    }
    public void WriteFile() {
        Console.WriteLine("Please enter a name for your file");
        string _fileName = Console.ReadLine() + ".txt";
        using (StreamWriter outputFile = new StreamWriter(_fileName)) {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _goalList) {
                if (goal is SimpleGoal simpleGoal) {
                    outputFile.WriteLine($"Simple:{simpleGoal.GetName()}:{simpleGoal.GetDescription()}:{simpleGoal.GetPoints()}:{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal) {
                    outputFile.WriteLine($"Eternal:{eternalGoal.GetName()}:{eternalGoal.GetDescription()}:{eternalGoal.GetPoints()}:{eternalGoal.IsComplete()}");
                }
                else if (goal is ChecklistGoal checklistGoal) {
                    outputFile.WriteLine($"Checklist:{checklistGoal.GetName()}:{checklistGoal.GetDescription()}:{checklistGoal.GetPoints()}:{checklistGoal.IsComplete()}:{checklistGoal.GetBonusPoints()}:{checklistGoal.GetBonusGoal()}:{checklistGoal.GetTimesComplete()}");
                }
                else if (goal is BadGoal badGoal) {
                    outputFile.WriteLine($"Bad:{badGoal.GetName()}:{badGoal.GetDescription()}:{badGoal.GetPoints()}:{badGoal.IsComplete()}");
                }
            }
        }
    }
    public void LoadFile() {
        Console.WriteLine("Please enter the name of the file you would like to load");
        string _fileName = Console.ReadLine() + ".txt";
        _goalList.Clear();
        try {
            _totalPoints = int.Parse(System.IO.File.ReadLines(_fileName).First());
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            foreach (string line in lines) {
                string[] parts = line.Split(':');
                if (parts.Length >= 4) {
                    string _type = parts[0];
                    string _name = parts[1];
                    string _description = parts[2];
                    int _points = int.Parse(parts[3]);
                    bool _complete = bool.Parse(parts[4]);
                    if (_type == "Simple") {
                        _goalList.Add(new SimpleGoal(_name, _description, _points, _complete));
                    }
                    else if (_type == "Eternal") {
                        _goalList.Add(new EternalGoal(_name, _description, _points, _complete));
                    }
                    else if (_type == "Checklist") {
                        int _bonusPoints = int.Parse(parts[5]);
                        int _bonusCompletions = int.Parse(parts[6]);
                        int _timesComplete = int.Parse(parts[7]);
                        _goalList.Add(new ChecklistGoal(_name, _description, _points, _complete, _bonusPoints, _bonusCompletions, _timesComplete));
                    }
                    else if (_type == "Bad") {
                        _goalList.Add(new BadGoal(_name, _description, _points, _complete));
                    }
                    else {
                        Console.WriteLine($"Invalid goal type");
                        continue; 
                    }
                }
            }
            Console.Write("File loaded. ");
        }
        catch (FileNotFoundException) {
        Console.Write($"File {_fileName} not found. ");
    }   
    }
    public void GoalProgress() {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goalList.Count; i++) {
            Console.WriteLine($"{i + 1}. {_goalList[i].GetName()}");
        }
        Console.Write("\nWhich goal did you accomplish?");
        int.TryParse(Console.ReadLine(), out int choice);
        choice -= 1;
        if (choice >= 0 && choice < _goalList.Count) {
            Goal selectedGoal = _goalList[choice];
            if (selectedGoal.IsComplete() != true) {
                _earnedPoints = selectedGoal.RecordEvent();
                if (selectedGoal.IsComplete()) {
                    Console.WriteLine($"Congratulations! You completed the goal and earned {_earnedPoints} points.");
                    _totalPoints += _earnedPoints;
                }
                if (_earnedPoints < 0) {
                    Console.WriteLine($"Progress recorded. You have lost {_earnedPoints *= -1} points.");
                    _totalPoints += _earnedPoints;
                }
                else {
                    Console.WriteLine($"Progress recorded. You have earned {_earnedPoints} points.");
                    _totalPoints += _earnedPoints;
                }   
            }
            else {
                    Console.WriteLine("You have already completed this goal.");
            }
        }
        else {
            Console.WriteLine("Invalid choice.");
        }

    }
    public void AddPoints(int points) {
        _totalPoints += points;
    }
    public int GetTotalPoints() {
        return _totalPoints;
    }
}

