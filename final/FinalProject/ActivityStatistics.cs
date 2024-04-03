class ActivityStatistics {
    private List<Activity> _activityList;

    private List<Activity> _coinList;

    private List<Activity> _spinnerList;

    private List<Activity> _diceList;

    private List<Activity> _cardList;
    public ActivityStatistics(List<Activity> activityList) {
        _activityList = activityList;
        _coinList = new List<Activity>();
        _spinnerList = new List<Activity>();
        _diceList = new List<Activity>();
        _cardList = new List<Activity>();

        foreach (Activity activity in _activityList) {
            if (activity is CoinActivity) {
                _coinList.Add(activity);
            }
            if (activity is SpinnerActivity) {
                _spinnerList.Add(activity);
            }
            if (activity is DiceActivity) {
                _diceList.Add(activity);
            }
            if (activity is CardActivity) {
                _cardList.Add(activity);
            }
        }
    }
    public void StatisticsMenu() {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Coin Flip");
        Console.WriteLine("    2. Spinner Wheel");
        Console.WriteLine("    3. Dice Roll");
        Console.WriteLine("    4. Draw Card");
        Console.Write("\nWhich activity would you like to see statistics for: ");
        string statisticsChoice = Console.ReadLine();

        while (statisticsChoice != "1" && statisticsChoice != "2" && statisticsChoice != "3") {
            Console.Write("Incorrect Choice. Please enter a valid entry: ");
            statisticsChoice = Console.ReadLine();
        }
        if (statisticsChoice == "1") {
            Console.WriteLine("Numerical results are calculated by assigning heads as 1 and tails as 2");
            RunStatistics(_coinList);
        }
        if (statisticsChoice == "2") {
            Console.WriteLine("Numerical results are calculated by assigning red, blue, green, and orange to 1, 2, 3, and 4, respectively.");
            RunStatistics(_spinnerList);
        }
        if (statisticsChoice == "3") {
            RunStatistics(_diceList);
        }
        if (statisticsChoice == "4") {
            Console.WriteLine("Numerical results are calculated by assigning face cards to their numerical values.");
            RunStatistics(_cardList);
        }
    }
    public void RunStatistics(List<Activity> selectedList) {
        DisplayAverage(selectedList);
        DisplaySums(selectedList);
        DisplayMostCommon(selectedList);
        Console.WriteLine("Press 'Enter' to return to the menu: ");
        Console.ReadLine();
    }
    public void DisplayAverage(List<Activity> selectedList) {
        double subtotal = 0;
        foreach (Activity activity in selectedList) {
            subtotal += activity.GetNumericalResult();
        }
        if (subtotal > 0) {
            double average = subtotal / selectedList.Count;
            Console.WriteLine($"The average result of this activity is: {average:F2}");
        }
        else {
            Console.Write("\nNo activities found for calculating the average.");
            Console.ReadLine();
        }

    }
    public void DisplaySums(List<Activity> selectedList) {
        //To Be Added
        //Show the sum of all results
    }
    public void DisplayMostCommon(List<Activity> selectedList) {
        //To Be Added
        //Coin: show most flipped side
        //Spinner: Show most spun side
        //Dice: Show most rolled side
        //Card: Show most drawn card, most drawn number, most drawn suit
    }
}