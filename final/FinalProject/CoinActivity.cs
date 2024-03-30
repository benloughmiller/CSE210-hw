class CoinActivity : Activity {
    //set the repetition amount in the manager class, increasing the amount each time the program is repeated. in this class, if repetition is greater than 1, cancel the intro prompt.
    public CoinActivity(int repetition) : base("Coin Flip", "This activity will flip a coin."){
        RunActivity(repetition);
    }
    public override void RunActivity(int repetition) {
        int _repetition = repetition;
        if (_repetition == 1) {
            ActivityStart();
        }
    }
}