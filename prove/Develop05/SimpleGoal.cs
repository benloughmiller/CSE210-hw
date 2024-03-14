class SimpleGoal : Goal {
    private int _simplePoints;
    public SimpleGoal(string name, string description, int goalPoints) : base("Simple", name, description, goalPoints) {
        _simplePoints = goalPoints;
    }
    public override bool IsComplete() {
        return _complete;
    }
    public override void RecordEvent() {
        AddPoints(_simplePoints);
        SetComplete(true);
    }
    
}