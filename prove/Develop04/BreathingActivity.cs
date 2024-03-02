
using System.Runtime.CompilerServices;

class BreathingActivity : Activity {

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {
    
    }
    public void RunBreathing() {
        ActivityStart();
        int _activityTime = GetDuration();
        SpinnyAnimation(500);
        CountdownTimer(5);
        BreathingInOut(_activityTime);
        ActivityEnd();
    }
    public void BreathingInOut(int activityTime) {
        Console.Clear();
        int _remainingTime = activityTime;
        while (_remainingTime > 0) {
            Console.WriteLine("Breathe in...");

            if (_remainingTime >= 5) {
                CountdownTimer(5);
                _remainingTime -= 5;
            }
            else {
                CountdownTimer(_remainingTime);
                _remainingTime -= _remainingTime;  
            }

        }
    }
}