class EternalGoal : Goal {
    private int _eternalPoints;
    public EternalGoal(string name, string description, int goalPoints) : base("Eternal", name, description, goalPoints) {
        _eternalPoints = goalPoints;
    }
    public override bool IsComplete() {
        return _complete;
    }
    public override void RecordEvent() {
        AddPoints(_eternalPoints);
    }
}