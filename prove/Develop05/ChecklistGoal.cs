using System.Formats.Asn1;

class ChecklistGoal : Goal{
    private int _basePoints;
    private int _bonusPoints;
    private int _timesComplete;
    private int _goalValue;
    public ChecklistGoal(string name, string description, int basePoints, bool complete, int bonusPoints, int bonusCompletions, int timesComplete) : base("Checklist", name, description, basePoints, complete, bonusPoints, bonusCompletions) {
        _basePoints = basePoints;
        _bonusPoints = bonusPoints;
        _goalValue = bonusCompletions;
        _timesComplete = timesComplete;
    }
    public override bool IsComplete() {
        return _timesComplete == _goalValue;
    }
    public int GetTimesComplete() {
        return _timesComplete;
    }
    public int GetGoalValue() {
        return _goalValue;
    }
    public override int RecordEvent() {
        if (_timesComplete < _goalValue - 1) {
            _timesComplete += 1;
            return AddPoints(_basePoints);
        }
        else {
            _timesComplete += 1;
            SetComplete(true);
            return AddPoints(_basePoints + _bonusPoints);   
        }
    }
}