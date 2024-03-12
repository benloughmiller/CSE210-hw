using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

class SimpleGoal : Goal {
    private int _basePoints;
    private bool _complete;
    public SimpleGoal(string name, string description, int basePoints) : base(name, description) {
        _basePoints = basePoints;
    }
    public override bool IsComplete() {
        return _complete;
    }
    public override void RecordEvent() {
        AddPoints(_basePoints);
        SetComplete(true);
    }
    
}