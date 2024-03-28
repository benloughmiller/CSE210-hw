class ActivityManager {
    private List<Activity> _activityList;
    public ActivityManager() {
    }
    Console.Write("\nHow many times would you like to run the activity?");
    int.TryParse(Console.ReadLine(), out int _runAmount);
    return _runAmount;
}