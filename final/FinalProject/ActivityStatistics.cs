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

        while (statisticsChoice != "1" && statisticsChoice != "2" && statisticsChoice != "3" && statisticsChoice != "4") {
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
    private void RunStatistics(List<Activity> selectedList) {
        DisplayAverage(selectedList);
        DisplaySum(selectedList);
        DisplayMostCommon(selectedList);
        Console.WriteLine("Press 'Enter' to return to the menu: ");
        Console.ReadLine();
    }
    private void DisplayAverage(List<Activity> selectedList) {
        double subtotal = 0;
        foreach (Activity activity in selectedList) {
            subtotal += activity.GetNumericalResult();
        }
        if (subtotal > 0) {
            double average = subtotal / selectedList.Count;
            Console.WriteLine($"\nThe average result of this activity is: {average:F2}");
        }
        else {
            Console.Write("\nNo activities found for calculating the average.");
            Console.ReadLine();
        }

    }
    private void DisplaySum(List<Activity> selectedList) {
        int total = 0;
        foreach (Activity activity in selectedList) {
            total += activity.GetNumericalResult();
        }
        Console.WriteLine($"\nThe total of all results for this activity is: {total}");
    }
    private void DisplayMostCommon(List<Activity> selectedList) {
        //Reference: https://www.geeksforgeeks.org/c-sharp-dictionary-containskey-method/
        Dictionary<string, int> cardResults = new Dictionary<string, int>();
        Dictionary<string, int> suitResults = new Dictionary<string, int>();
        Dictionary<string, int> rankResults = new Dictionary<string, int>();
        Dictionary<string, int> countResults = new Dictionary<string, int>();

        foreach (Activity activity in selectedList) {
        if (activity is CardActivity) {
                CardActivity cardActivity = (CardActivity)activity;
                string suit = cardActivity.GetSuit();
                string rank = cardActivity.GetRank();
                string card = $"{rank} of {suit}";
                if (suitResults.ContainsKey(suit)) {
                    suitResults[suit]++;
                }
                else {
                    suitResults[suit] = 1;
                }
                if (rankResults.ContainsKey(rank)) {
                    rankResults[rank]++;
                }
                else {
                    rankResults[rank] = 1;
                }
                if (cardResults.ContainsKey(card)) {
                    cardResults[card]++;
                }
                else {
                    cardResults[card] = 1;
                } 
            }
            else {
                string result = activity.GetResult();
                if (countResults.ContainsKey(result)) {
                    countResults[result]++;
                } 
                else {
                    countResults[result] = 1;
                }
            }
        }
        Console.WriteLine("Sorted Outcomes:");
        foreach (var value in countResults.OrderByDescending(pair => pair.Value)) {
            Console.WriteLine($"{value.Key}: {value.Value}");
        }
        if (cardResults.Keys.Any(key => key.Contains("of"))) {
            Console.WriteLine("\nSorted Suits:");
            foreach (var value in suitResults.OrderByDescending(pair => pair.Value)) {
                Console.WriteLine($"{value.Key}: {value.Value}");
            }
            Console.WriteLine("\nSorted Ranks:");
            foreach (var value in rankResults.OrderByDescending(pair => pair.Value)) {
                Console.WriteLine($"{value.Key}: {value.Value}");
            }
            Console.WriteLine("\nRanked Cards:");
            foreach (var value in cardResults.OrderByDescending(pair => pair.Value)) {
                Console.WriteLine($"{value.Key}: {value.Value}");
            }
        }

    }
}