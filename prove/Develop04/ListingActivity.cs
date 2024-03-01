class ListingActivity : Activity {
    private int _responses;
    private List<string> _listPrompts = new List<string>();
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {
        _listPrompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"  
        };
    }
    public void RunListing() {
        ActivityStart();
        ActivityEnd();
    }
    public void GetListPrompt() {

    }
    public void DisplayPrompt() {

    }
    public int CountResponses() {
        return _responses;
    }
}