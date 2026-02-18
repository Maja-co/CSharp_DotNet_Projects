// See https://aka.ms/new-console-template for more information


CardGame game = new CardGame();
game.AddCard(Suit.Clubs, Number.Six);
game.AddCard(Suit.Hearts, Number.Jack);
game.AddCard(Suit.Diamonds, Number.Three);

var pictureCards = game.filterCardGame(CardGame.FilterByPictureCards);
var nonPictureCards = game.filterCardGame(CardGame.FilterByNonPictureCards);

foreach (Card c in pictureCards) Console.WriteLine(c);
foreach (Card c in nonPictureCards) Console.WriteLine(c);


enum Suit {
    Hearts,
    Clubs,
    Diamonds,
    Spades
}

enum Number {
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Jack,
    Queen,
    King
}

class Card {
    public Suit Suit { get; set; }
    public Number Number { get; set; }

    public Card(Suit suit, Number number) {
        Suit = suit;
        Number = number;
    }

    public delegate bool FilterCardDelegate(Card card);

    public override string ToString() {
        return $"Suit: {Suit}, Number: {Number}";
    }
}

class CardGame {
    private List<Card> cards = new List<Card>();

    public void AddCard(Suit suit, Number number) {
        cards.Add(new Card(suit, number));
    }

    public List<Card> filterCardGame(Card.FilterCardDelegate filter) {
        List<Card> filteredCards = new List<Card>();
        foreach (Card card in cards) {
            if (filter(card)) filteredCards.Add(card);
        }

        return filteredCards;
    }

    public static bool FilterByClubs(Card card) => card.Suit == Suit.Clubs;

    public static bool FilterByPictureCards(Card card) =>
        card.Number == Number.Jack || card.Number == Number.Queen || card.Number == Number.King;

    public static bool FilterByNonPictureCards(Card card) =>
        card.Number != Number.Jack && card.Number != Number.Queen && card.Number != Number.King;
}