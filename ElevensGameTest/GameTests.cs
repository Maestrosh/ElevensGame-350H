using Xunit;

public class GameTests
{
    [Fact]
    public void Game_Should_Initialize_With_Proper_Deck_And_Board()
    {
        // Arrange
        var game = new Game();

        // Act
        var cardsOnBoard = game.Board.GetCardsOnBoard();
        var cardsRemaining = game.Deck.CardsRemaining();

        // Assert
        Assert.Equal(9, cardsOnBoard.Count);
        Assert.Equal(43, cardsRemaining);
    }

    [Fact]
    public void HasValidMoves_Should_Return_True_For_Valid_Board()
    {
        // Arrange
        var game = new Game();

        // Act
        var hasValidMoves = game.HasValidMoves();

        // Assert
        Assert.True(hasValidMoves);
    }
}
