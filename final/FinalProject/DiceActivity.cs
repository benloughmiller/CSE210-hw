class DiceActivity : Activity{
    public DiceActivity(int repetition, int maximum) : base("Dice", "This activity will roll a 6-sided die."){
        RunActivity(repetition, maximum);
    }
    protected override void CalcActivity() {
         _result = GetRandomNumber(6).ToString();
        Console.WriteLine($"You Rolled a {_result}");
        Thread.Sleep(1000);
    }
}