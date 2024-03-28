class CoinActivity : Activity {
    private int _repetition;
    //set the repetition amount in the manager class, increasing the amount each time the program is repeated. in this class, if repetition is greater than 1, cancel the intro prompt.
    public CoinActivity(int repetition) : base("Coin Flip", "This activity will flip a coin."){
        _repetition = repetition;
    }
    public override void RunActivity() {
        ActivityStart();
    }
}