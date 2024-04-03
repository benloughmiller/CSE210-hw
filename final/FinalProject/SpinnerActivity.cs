class SpinnerActivity : Activity{
    

    public SpinnerActivity(int repetition, int maximum) : base("Spinner", "This activity will spin a wheel with 4 possible results."){
        RunActivity(repetition, maximum);
    }


    protected override void CalcActivity() {
        SpinnyAnimation(100);
        int numberResult = GetRandomNumber(4);
        if (numberResult == 1) {
            _result = "Red";
        }
        if (numberResult == 2) {
            _result = "Blue";
        }
        if (numberResult == 3) {
            _result = "Green";
        }
        if (numberResult == 4) {
            _result = "Orange";
        }
        Console.WriteLine($"{_result} was spun.");
    }
}