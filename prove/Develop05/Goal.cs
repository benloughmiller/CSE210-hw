abstract class Goal {
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    public Goal(string goalType, string name, string description, int points) {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }
        public Goal(string goalType, string name, string description, int points, int bonusPoints, int bonusCompletions) {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }
    public void GetBaseInfo() {
        
    }
    public int GetPoints() {
        return _points;
    }
    public void AddPoints(int points) {
        _points += points;
    }
    protected void SetComplete(bool value) {
        _complete = value;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
}