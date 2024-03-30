class SpinnerActivity : Activity{
    

    public SpinnerActivity(int repetition, int maximum) : base("Spinner Wheel", "This activity will spin a wheel with 4 possible results."){
        RunActivity(repetition, maximum);
    }


    protected override void CalcActivity() {
        SpinnyAnimation(200);
        int _result = GetRandomNumber(4);
    }
}