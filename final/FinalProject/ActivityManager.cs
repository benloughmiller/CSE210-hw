
class ActivityManager {
    private List<Activity> _activityList;
    public ActivityManager() {
        _activityList = new List<Activity>();
    }
    public void NewActivity(int selection, int repetition) {
        for (int i = 1; i <= repetition; i++) {
            if (selection == 1) {
                _activityList.Add(new CoinActivity(i));
            }
            if (selection == 2) {
                _activityList.Add(new SpinnerActivity(i));
            }
            if (selection == 3) {
                _activityList.Add(new DiceActivity(i));
            }
            if (selection == 4) {
                _activityList.Add(new CardActivity(i));
            }
        }
    }
    public void DisplayList() {

    }
    public void SaveList() {

    }
    public void LoadList() {

    }
    public List<Activity> GetList() {
        return _activityList;
    }
}