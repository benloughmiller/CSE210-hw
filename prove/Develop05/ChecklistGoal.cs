class ChecklistGoal : Goal{
    private int _basePoints;
    public int _timesComplete;
    private int _bonusPoints;
    public int _goalValue;
    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int bonusCompletions) : base("Checklist", name, description, goalPoints, bonusPoints, bonusCompletions) {
        _basePoints = goalPoints;
        _bonusPoints = bonusPoints;
        _goalValue = bonusCompletions;
        _timesComplete = 0;
    }
    public override bool IsComplete() {
        return _timesComplete == _goalValue;
    }
    public override void RecordEvent() {
        _timesComplete += 1;
        if (_timesComplete == _goalValue) {
            AddPoints(_basePoints + _bonusPoints);
            SetComplete(true);
        }
        else {
            AddPoints(_basePoints + _bonusPoints);
        }
    
    }
}