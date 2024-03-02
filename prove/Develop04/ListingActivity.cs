class ListingActivity : Activity {
    private List<string> _listPrompts = new List<string>();
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {
        _listPrompts = new List<string>() {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"  
        };
    }
    public void RunListing() {
        ActivityStart();
        int _activityTime = GetDuration();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetListPrompt();
        Console.Write("You may begin in: ");
        CountdownTimer(5);
        Console.WriteLine();
        UserResponses(_activityTime);
        ActivityEnd();
    }
    public void GetListPrompt() {
        Random _random = new Random();
        int _randomPrompt = _random.Next(_listPrompts.Count);
        string _displayPrompt = "---- " + _listPrompts[_randomPrompt] + " ----";
        Console.WriteLine(_displayPrompt);
    }

    public void UserResponses(int time) {
        int _remainingTime = time;
        int _responses = 0;
        DateTime _startTime = DateTime.Now;
        DateTime _futureTime = _startTime.AddSeconds(_remainingTime);

        while (DateTime.Now < _futureTime) {
            Console.Write("> ");
            Console.ReadLine();
            _responses += 1;
        }    
        Console.WriteLine($"You listed {_responses} items!\n");
    }
}