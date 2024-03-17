class BadGoal : Goal {
    private int _basePoints;
    public BadGoal(string name, string description, int basePoints, bool complete) : base("Bad", name, description, basePoints, complete) {
        _basePoints = basePoints;
    }
    public override bool IsComplete() {
        return _complete;
    }
    public override int RecordEvent() {
        return AddPoints(_basePoints *= -1);
    }
}