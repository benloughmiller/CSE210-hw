using System.Reflection.Metadata.Ecma335;

class CardActivity : Activity{
    private string _suit;
    private string _rank;
    private List<string> _suitsList = new List<string> {"Hearts", "Diamonds", "Clubs", "Spades"};
    private List<string> _rankList = new List<string> {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
    public CardActivity(int repetition, int maximum) : base("Card Draw", "This activity will pick a card at random from a full deck.") {
        RunActivity(repetition, maximum);
    }
    protected override void CalcActivity() {
        _suit = _suitsList[GetRandomNumber(_suitsList.Count) - 1];
        _rank = _rankList[GetRandomNumber(_rankList.Count) - 1];
        Console.WriteLine($"You picked the {_rank} of {_suit}.");
        Console.ReadLine();
    }
    public string GetSuit() {
        return _suit;
    }
    public string GetRank() {
        return _rank;
    }
}