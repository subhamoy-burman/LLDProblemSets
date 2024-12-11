using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class BoardBox
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public ChessElement Piece { get; set; }

        public BoardBox(int rowNumber, int colNumber, ChessElement piece)
        {
            
        }
    }
}
