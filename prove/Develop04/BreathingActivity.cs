
class BreathingActivity : Activity {
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {

    }
    public void RunBreathing() {
        ActivityStart();
        int _duration = GetDuration();
        SpinnyAnimation(500);
        CountdownTimer(5);
        ActivityEnd();
    }
    public void BreathingInOut() {
    }
}