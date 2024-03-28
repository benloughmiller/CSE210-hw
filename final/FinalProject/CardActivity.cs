class CardActivity : Activity{
    private List<string> _suits = new List<string> {"Hearts", "Diamonds", "Clubs", "Spades"};
    private List<string> _values = new List<string> {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
    public CardActivity() : base("card", "This activity will pick at random from a full deck of cards.") {
    }
    public override void RunActivity() {
        ActivityStart();
    }
}