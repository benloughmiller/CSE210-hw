class DiceActivity : Activity{
    public DiceActivity(int repetition) : base("Dice Roll", "This activity will roll a 6-sided die."){
        RunActivity(repetition);
    }
    public override void RunActivity(int repetition) {
        int _repetition = repetition;
        if (_repetition == 1) {
            ActivityStart();
        }
    }
}