
class ActivityManager {
    private List<Activity> _activityList;
    public ActivityManager() {
        _activityList = new List<Activity>();
    }

    public void ManagerMenu() {
        Console.Clear();
        Console.WriteLine("Activity Options:");
        Console.WriteLine("    1. Coin Flip");
        Console.WriteLine("    2. Spinner Wheel");
        Console.WriteLine("    3. Dice Roll");
        Console.WriteLine("    4. Draw Card");
        Console.Write("\nWhich activity would you like to run: ");
        string activityChoice = Console.ReadLine();

        while (activityChoice != "1" && activityChoice != "2" && activityChoice != "3" && activityChoice != "4") {
            Console.Write("Incorrect Choice. Please enter a valid entry: ");
            activityChoice = Console.ReadLine();
        }
        Console.Write("\nHow many times would you like to run the activity? ");
        int.TryParse(Console.ReadLine(), out int runAmount);
        
        NewActivity(int.Parse(activityChoice), runAmount);
    }
    public void NewActivity(int selection, int repetition) {
        for (int i = 1; i <= repetition; i++) {
            if (selection == 1) {
                _activityList.Add(new CoinActivity(i, repetition));
            }
            if (selection == 2) {
                _activityList.Add(new SpinnerActivity(i, repetition));
            }
            if (selection == 3) {
                _activityList.Add(new DiceActivity(i, repetition));
            }
            if (selection == 4) {
                _activityList.Add(new CardActivity(i ,repetition));
            }
        }
    }
    public void DisplayList() {
        Console.Clear();
        int i = 0;
        foreach (Activity activity in _activityList) {
            Console.Write($"\n{i += 1}. {activity.GetName()}, Result: {activity.GetResult()}");
            if (activity is CardActivity cardActivity) {
                Console.Write($"{cardActivity.GetRank()} of {cardActivity.GetSuit()}");
            }
        }
        Console.WriteLine("\nPress 'Enter' to return to the menu:");
        Console.ReadLine();
    }
    public List<Activity> GetActivityList() {
        return _activityList;
    }
}