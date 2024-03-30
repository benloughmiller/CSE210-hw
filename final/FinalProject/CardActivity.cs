using System.Reflection.Metadata.Ecma335;

class CardActivity : Activity{
    private string _suit;
    private string _value;
    private List<string> _suits = new List<string> {"Hearts", "Diamonds", "Clubs", "Spades"};
    private List<string> _values = new List<string> {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
    public CardActivity(int repetition, int maximum) : base("Card Draw", "This activity will pick a card at random from a full deck.") {
        RunActivity(repetition, maximum);
    }
    protected override void CalcActivity() {
        _suit = _suits[GetRandomNumber(_suits.Count) - 1];
        _value = _values[GetRandomNumber(_values.Count) - 1];
        Console.WriteLine($"You picked the {_value} of {_suit}.");
        Console.ReadLine();
    }
    public string GetSuit() {
        return _suit;
    }
    public string GetValue() {
        return _value;
    }
}