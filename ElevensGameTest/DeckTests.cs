using Xunit;

public class DeckTests
{
    [Fact]
    public void Deck_Should_Contain_52_Cards_Initially()
    {
        // Arrange
        var deck = new Deck();

        // Act
        int cardCount = deck.CardsRemaining();

        // Assert
        Assert.Equal(52, cardCount);
    }

    [Fact]
    public void Shuffle_Should_Randomize_Deck_Order()
    {
        // Arrange
        var deck1 = new Deck();
        var deck2 = new Deck();

        // Act
        deck1.Shuffle();
        var originalOrder = new List<Card>(deck2.CardsRemaining());
        var shuffledOrder = new List<Card>(deck1.CardsRemaining());

        // Assert
        Assert.NotEqual(originalOrder, shuffledOrder);
    }

    [Fact]
    public void Deal_Should_Remove_A_Card()
    {
        // Arrange
        var deck = new Deck();

        // Act
        var dealtCard = deck.Deal();
        int remainingCards = deck.CardsRemaining();

        // Assert
        Assert.NotNull(dealtCard);
        Assert.Equal(51, remainingCards);
    }
}
