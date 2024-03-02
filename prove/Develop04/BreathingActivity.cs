
using System.Runtime.CompilerServices;

class BreathingActivity : Activity {

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {
    
    }
    public void RunBreathing() {
        ActivityStart();
        int _activityTime = GetDuration();
        SpinnyAnimation(300);
        BreathingInOut(_activityTime);
        ActivityEnd();
    }
    public void BreathingInOut(int activityTime) {
        int _remainingTime = activityTime;
        Console.WriteLine();
        while (_remainingTime > 0) {
            Console.Write("Breathe in... ");
            if (_remainingTime >= 10) {
                CountdownTimer(5);
                _remainingTime -= 5;
            }
            else {
                _remainingTime /= 2;
                CountdownTimer(_remainingTime); 
            }
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            if (_remainingTime > 5) {
                CountdownTimer(5);
                _remainingTime -= 5;
            }
            else {
                CountdownTimer(_remainingTime);
                _remainingTime -= _remainingTime;  
            }
            Console.WriteLine("\n");
        }
    }
}