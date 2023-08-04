using ChessChallenge.API;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        // create an evalute function

        // create a search function
        
        Move[] moves = board.GetLegalMoves();
        return moves[0];
    }
}