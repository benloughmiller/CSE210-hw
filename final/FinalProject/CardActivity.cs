class CardActivity : Activity{
    private List<string> _suits = new List<string> {"Hearts", "Diamonds", "Clubs", "Spades"};
    private List<string> _values = new List<string> {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
    public CardActivity(int repetition) : base("Card Draw", "This activity will pick a card at random from a full deck.") {
        RunActivity(repetition);
    }
    public override void RunActivity(int repetition) {
        int _repetition = repetition;
        if (_repetition == 0) {
            ActivityStart();
        }
        int _randomSuitInt = GetRandomNumber(_suits.Count) - 1;
        int _randomvalueInt = GetRandomNumber(_values.Count) - 1;
        string _randomSuit = _suits[_randomSuitInt];
        string _randomValue = _values[_randomvalueInt];
        Console.WriteLine($"You picked the {_randomValue} of {_randomSuit}.");
    }
}