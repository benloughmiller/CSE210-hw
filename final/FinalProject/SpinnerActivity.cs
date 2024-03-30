class SpinnerActivity : Activity{
    
    private List <string> _animation = new List<string>();
    public SpinnerActivity(int repetition) : base("Spinner Wheel", "This activity will spin a wheel with 4 possible results."){
        _animation = new List<string>() {
            "—", "\\", "|", "/", "—", "\\", "|", "/" 
        };
        RunActivity(repetition);
    }
    private void SpinnyAnimation(int wait) {
        foreach (string s in _animation) {
            Console.Write(s);
            Thread.Sleep(wait);
            Console.Write("\b \b");
        }
    }
    public override void RunActivity(int repetition) {
        int _repetition = repetition;
        if (_repetition == 0) {
            ActivityStart();
        }
    }
}