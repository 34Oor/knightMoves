using knightMoves.Services;

namespace KnightMovesTests.ServicesTests;

public class KnightServiceTests
{
    private KnightService _knightService { get; set; }
    public KnightServiceTests()
    {
        _knightService = new KnightService();
    }


    [Theory]
    [InlineData("a1", new object[] { "b3", "c2" })]
    [InlineData("a2", new object[] { "b4", "c1", "c3" })]
    [InlineData("a3", new object[] { "b1", "b5", "c2", "c4" })]
    [InlineData("a4", new object[] { "b2", "b6", "c3", "c5" })]
    [InlineData("a5", new object[] { "b3", "b7", "c4", "c6" })]
    [InlineData("a6", new object[] { "b4", "b8", "c5", "c7" })]
    [InlineData("a7", new object[] { "b5", "c6", "c8" })]
    [InlineData("a8", new object[] { "b6", "c7" })]

    [InlineData("b1", new object[] { "a3", "c3", "d2" })]
    [InlineData("b2", new object[] { "a4", "c4", "d1", "d3" })]
    [InlineData("b3", new object[] { "a1", "a5", "c1", "c5", "d2", "d4" })]
    [InlineData("b4", new object[] { "a2", "a6", "c2", "c6", "d3", "d5" })]
    [InlineData("b5", new object[] { "a3", "a7", "c3", "c7", "d4", "d6" })]
    [InlineData("b6", new object[] { "a4", "a8", "c4", "c8", "d5", "d7" })]
    [InlineData("b7", new object[] { "a5", "c5", "d6", "d8" })]
    [InlineData("b8", new object[] { "a6", "c6", "d7" })]

    [InlineData("d1", new object[] { "b2", "c3", "e3", "f2" })]
    [InlineData("d2", new object[] { "b1", "b3", "c4", "e4", "f1", "f3" })]
    [InlineData("d3", new object[] { "b2", "b4", "c1", "c5", "e1", "e5", "f2", "f4" })]
    [InlineData("d4", new object[] { "b3", "b5", "c2", "c6", "e2", "e6", "f3", "f5" })]
    [InlineData("d5", new object[] { "b4", "b6", "c3", "c7", "e3", "e7", "f4", "f6" })]
    [InlineData("d6", new object[] { "b5", "b7", "c4", "c8", "e4", "e8", "f5", "f7" })]
    [InlineData("d7", new object[] { "b6", "b8", "c5", "e5", "f6", "f8" })]
    [InlineData("d8", new object[] { "b7", "c6", "e6", "f7" })]

    [InlineData("g1", new object[] { "e2", "f3", "h3" })]
    [InlineData("g2", new object[] { "e1", "e3", "f4", "h4" })]
    [InlineData("g3", new object[] { "e2", "e4", "f1", "f5", "h1", "h5" })]
    [InlineData("g4", new object[] { "e3", "e5", "f2", "f6", "h2", "h6" })]
    [InlineData("g5", new object[] { "e4", "e6", "f3", "f7", "h3", "h7" })]
    [InlineData("g6", new object[] { "e5", "e7", "f4", "f8", "h4", "h8" })]
    [InlineData("g7", new object[] { "e6", "e8", "f5", "h5" })]
    [InlineData("g8", new object[] { "e7", "f6", "h6" })]

    [InlineData("h1", new object[] { "f2", "g3" })]
    [InlineData("h2", new object[] { "f1", "f3", "g4" })]
    [InlineData("h3", new object[] { "f2", "f4", "g1", "g5" })]
    [InlineData("h4", new object[] { "f3", "f5", "g2", "g6" })]
    [InlineData("h5", new object[] { "f4", "f6", "g3", "g7" })]
    [InlineData("h6", new object[] { "f5", "f7", "g4", "g8" })]
    [InlineData("h7", new object[] { "f6", "f8", "g5" })]
    [InlineData("h8", new object[] { "f7", "g6" })]


    // Add more test cases for all possible positions if needed.
    public void GetPossibleMoves_WithCurrentPosition_ReturnsAllPossibleMoves(string currentPosition, object[] expectedMoves)
    {
        // Arrange

        // Act
        var actualMoves = _knightService.GetPossibleMoves(currentPosition);

        // Assert
        Assert.Equal(expectedMoves, actualMoves);
    }

}

