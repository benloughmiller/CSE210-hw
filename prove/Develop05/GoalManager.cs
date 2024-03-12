class GoalManager {
    private List<Goal> _goalList;
    public GoalManager() {
        _goalList = new List<Goal>();
    }

    public void ViewGoals() {
        int i = 0;
        foreach (Goal goal in _goalList) {
            Console.WriteLine($"{i += 1}. {completionStatus} {goal.Description} ({goal.Points} points)");
        }
        Console.WriteLine($"\nTotal Points Gained: {totalPoints}");
    }
    public void WriteFile() {
        Console.WriteLine("Please enter a name for your file");
        string _fileName = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(_fileName)) {
            foreach (Goal goal in _goalList) {
                outputFile.WriteLine(goal);
            }
            Console.WriteLine("File saved");
        }
    }
    public void LoadFile() {
                Console.WriteLine("Please enter the name of the file you would like to load");
        string _filename = Console.ReadLine() + ".txt";
        _goalList.Clear();

        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines) {
         _goalList.Add(line);
        }
        Console.WriteLine("File loaded");
    }
}