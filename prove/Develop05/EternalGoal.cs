class EternalGoal : Goal {
    private int _basePoints;
    public EternalGoal(string name, string description, int basePoints, bool complete) : base("Eternal", name, description, basePoints, complete) {
        _basePoints = basePoints;
    }
    public override bool IsComplete() {
        return _complete;
    }
    public override int RecordEvent() {
        return AddPoints(_basePoints);
    }
}