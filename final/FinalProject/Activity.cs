abstract class Activity {
    private List <string> _animation = new List<string>();
    public Activity() {
        _animation = new List<string>() {
            "|", "/", "—", "\\", "|", "/", "—", "\\"
        };
    }
    public void SpinnyAnimation(int wait) {
        foreach (string s in _animation) {
            Console.Write(s);
            Thread.Sleep(wait);
            Console.Write("\b \b");
        }

    }
}