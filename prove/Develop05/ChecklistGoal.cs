class ChecklistGoal {
    private int _basePoints;
    private int _timesComplete;
    private int _bonusPoints;
    private int _goalValue;
    private bool _complete;
    public ChecklistGoal(string name, string description, int basePoints, int bonusPoints, int bonusCompletions) : base("Checklist", name, description, basePoints, bonusPoints, bonusCompletions) {

    }
    public bool IsComplete() {
        return _complete;
    }
    public void RecordEvent() {

    }



}