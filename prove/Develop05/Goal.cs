abstract class Goal {
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    public Goal(string name, string description) {
        _name = name;
        _description = description;
        _points = 0;
        _complete = false;
    }
    public int GetPoints() {
        return _points;
    }
    public void AddPoints(int points) {
        _points += points;
    }
    protected void SetComplete(bool value) {
        _complete = value;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
}