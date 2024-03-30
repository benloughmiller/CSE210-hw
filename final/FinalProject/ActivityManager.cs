
class ActivityManager {
    private List<Activity> _activityList;
    public ActivityManager() {
        _activityList = new List<Activity>();
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
        //To Be Added
    }
    public List<Activity> PassList() {
        return _activityList;
    }
}