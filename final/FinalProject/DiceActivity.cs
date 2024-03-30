class DiceActivity : Activity{
    public DiceActivity(int repetition, int maximum) : base("Dice Roll", "This activity will roll a 6-sided die."){
        RunActivity(repetition, maximum);
    }
    protected override void CalcActivity() {
        int result = GetRandomNumber(6);
        Console.WriteLine($"You Rolled a {result}");
        Console.ReadLine();
    }
}