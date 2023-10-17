namespace knightMoves.Services;

public interface IKnightService
{
    List<string> GetPossibleMoves(string currentPosition);
}

public class KnightService : IKnightService
{

    /// <summary>
    /// Get list of all possible moves of a knight given the current position.
    /// </summary>
    /// <param name="currentPosition"> e.g., a1, a2,..., b1, b2,...</param>
    /// <returns></returns>
    public List<string> GetPossibleMoves(string currentPosition)
    {
        // Subtracts the ASCII value of the first file 'a' from the current file ASCII value to get zero-based X coordinate.
        var currentX = currentPosition[0] - 'a';
        // Subtracts Rank '1' from the current Rank value to get zero-based Y coordinate.
        var currentY = int.Parse(currentPosition[1].ToString()) - 1;

        var possibleMoves = new List<string>();

        // Define all possible knight moves relative to the current position.
        var xOffset = new []{ -2, -2, -1, -1, 1, 1, 2, 2 };
        var yOffset = new []{ -1, 1, -2, 2, -2, 2, -1, 1 };

        for (var i = 0; i < xOffset.Length; i++)
        {
            var candidateX = currentX + xOffset[i];
            var candidateY = currentY + yOffset[i];

            // Check we didn't get out of the chess board.
            if (IsValidMove(candidateX, candidateY))
            {
                // Add new possible move.
                char newFile = (char)('a' + candidateX);
                int newRank = candidateY + 1;
                string newPosition = $"{newFile}{newRank}";
                possibleMoves.Add(newPosition);
            }
        }

        return possibleMoves;
    }

    private static bool IsValidMove(int x, int y)
    => x >= 0 && x < 8 && y >= 0 && y < 8;
}
