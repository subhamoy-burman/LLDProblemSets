using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Board
    {
        public BoardBox[,] Boxes { get; set; }
        public Player[] Players { get; set; }
        public Player CurrentEnabledPlayer { get; set; }

        public Board()
        {
            Boxes = new BoardBox[8, 8];
            Players = new Player[2];

            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Boxes[i, j] = new BoardBox(i, j, new ChessElement());
                }
            }

        }
    }

}
