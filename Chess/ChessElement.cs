namespace Chess
{
    public class ChessElement
    {
        public Guid ElementId { get; set; }
        public ChessElementType PieceType { get; set; }

        /// <summary>
        /// Defining all the allowed movements in X,Y plane
        /// </summary>
        public List<Tuple<int,int>> AllowedMovements { get; set; }
        public bool IsWhite { get; set; }
        public bool IsKilled { get; set; }


        public bool CanMove(int currentRow, int currentColumn, 
            int targetRow, int targetColumn)
        {
            return false;
        }

    }


    public enum ChessElementType
    {
        Rook,
        Knight,
        King,
        Queen,
        Pawn,
        Bishop
    }
}