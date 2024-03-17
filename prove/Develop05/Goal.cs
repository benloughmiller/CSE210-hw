using System.Runtime.CompilerServices;

abstract class Goal {
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;
    protected bool _complete;
    private int _bonusPoints;
    private int _bonusGoal;

    public Goal(string goalType, string name, string description, int points, bool complete) {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;

    }
    public Goal(string goalType, string name, string description, int points, bool complete, int bonusPoints, int bonusGoal) {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
        _bonusPoints = bonusPoints;
        _bonusGoal = bonusGoal;
        _complete = complete;
    }
    public string GetName() {
        return _name;
    }
    public string GetDescription() {
        return _description;
    }
    public int GetPoints() {
        return _points;
    }
    public int GetBonusPoints() {
        return _bonusPoints;
    }
    public int GetBonusGoal() {
        return _bonusGoal;
    }
    public int AddPoints(int points) {
        return points;
    }
    protected void SetComplete(bool complete) {
        _complete = complete;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
}