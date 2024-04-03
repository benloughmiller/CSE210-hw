class CoinActivity : Activity {
    public CoinActivity(int repetition, int maximum) : base("Coin", "This activity will flip a coin."){
        RunActivity(repetition, maximum);
    }
    protected override void CalcActivity() {
        SpinnyAnimation(200);
        int numberResult = GetRandomNumber(2);

        if (numberResult == 1) {
            _result = "Heads";   
        }
        if (numberResult == 2) {
            _result = "Tails";
        }
        Console.WriteLine(_result);
    }

}