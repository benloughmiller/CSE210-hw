class CoinActivity : Activity {
    public CoinActivity(int repetition, int maximum) : base("Coin Flip", "This activity will flip a coin."){
        RunActivity(repetition, maximum);
    }
    protected override void CalcActivity() {
        SpinnyAnimation(100);
        int result = GetRandomNumber(2);

        if (result == 1) {
            Console.WriteLine("Heads");
        }
        if (result == 2) {
            Console.WriteLine("Tails");
        }
        Console.ReadLine();
    }
}