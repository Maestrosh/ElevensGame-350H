using Xunit;

public class BoardTests
{
    [Fact]
    public void FillBoard_Should_Add_Cards_To_Board()
    {
        // Arrange
        var deck = new Deck();
        var board = new Board();

        // Act
        board.FillBoard(deck);

        // Assert
        Assert.Equal(9, board.GetCardsOnBoard().Count);
    }

    [Theory]
    [InlineData(0, 1, true)] // Valid pair summing to 11
    [InlineData(2, 3, false)] // Invalid pair
    public void ValidatePair_Should_Return_Correct_Result(int card1Index, int card2Index, bool expectedResult)
    {
        // Arrange
        var deck = new Deck();
        var board = new Board();
        board.FillBoard(deck);

        // Act
        var result = board.ValidatePair(card1Index, card2Index);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ValidateTrio_Should_Return_True_For_Valid_Trio()
    {
        // Arrange
        var deck = new Deck();
        var board = new Board();

        // Add mock cards for Jack, Queen, King
        board.GetCardsOnBoard().AddRange(new List<Card>
        {
            new Card("Jack", "Hearts", 10),
            new Card("Queen", "Hearts", 10),
            new Card("King", "Hearts", 10),
        });

        // Act
        var isValidTrio = board.ValidateTrio(new[] { 0, 1, 2 });

        // Assert
        Assert.True(isValidTrio);
    }
}
