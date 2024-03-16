class SimpleGoal : Goal {
    private int _basePoints;
    public SimpleGoal(string name, string description, int basePoints, bool complete) : base("Simple", name, description, basePoints, complete) {
        _basePoints = basePoints;
    }
    public override bool IsComplete() {
        return _complete;
    }
    public override int RecordEvent() {
        SetComplete(true);
        return AddPoints(_basePoints);
    }
}
    