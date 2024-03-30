class ActivityManager {
    private List<Activity> _activityList;
    public ActivityManager() {
        _activityList = new List<Activity>() {
    };
    }
    public void NewActivity(int selection) {
        if (selection == 1) {
            _activityList.Add(new CoinActivity(0));
        }
        if (selection == 2) {
            _activityList.Add(new SpinnerActivity(0));
        }
        if (selection == 3) {
            _activityList.Add(new DiceActivity(0));
        }
        if (selection == 4) {
            _activityList.Add(new CardActivity(0));
        }
        Console.Write("\nHow many times would you like to run the activity?");
        int.TryParse(Console.ReadLine(), out int _runAmount);
    }

}