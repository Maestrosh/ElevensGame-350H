using Xunit;

public class CardTests
{
    [Fact]
    public void Card_ToString_ReturnsCorrectFormat()
    {
        // Arrange
        var card = new Card("Ace", "Spades", 1);

        // Act
        var result = card.ToString();

        // Assert
        Assert.Equal("Ace of Spades", result);
    }
}
