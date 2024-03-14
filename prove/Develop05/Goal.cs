abstract class Goal {
    protected string _goalType;
    public string _name;
    public string _description;
    public int _points;
    protected bool _complete;
    public int _bonusPoints;
    public int _bonusCompletions;

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
        _bonusPoints = bonusPoints;
        _bonusCompletions = bonusCompletions;
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