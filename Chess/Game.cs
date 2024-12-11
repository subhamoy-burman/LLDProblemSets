using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Game
    {
        public Stack<Board> BoardLogs { get; set; }
        public BoardBox[,] CurrentStateOfBoardBoxes { get; set; }
        public Player Winner { get; set; }
        public Board CurrentGameBoard { get; set; }

        public Game()
        {
            
        }

        public void ServeAMove(Player player, ChessElement element, int currentRow, int currentColumn,
            int targetRow, int targetColumn)
        {

            if (isMovementAllowed(element, currentRow, currentColumn, targetRow, targetColumn))
            {
                if (IsGameExitConditionmet())
                {
                    Winner = player;
                }
                //CurrentStateOfBoardBoxes = 
                //Set the NextPlayer
                SetNextPlayer(player);
            }
            else
            {
                return;
            }

        }

        private bool IsGameExitConditionmet()
        {
            throw new NotImplementedException();
        }

        private bool isMovementAllowed(ChessElement element, int currentRow, int currentColumn, int targetRow, int targetColumn)
        {
            throw new NotImplementedException();
        }

        private Player SetNextPlayer(Player player)
        {
            if (player == CurrentGameBoard.Players[0])
            {
                CurrentGameBoard.CurrentEnabledPlayer = CurrentGameBoard.Players[1];
            }
            else
            {
                CurrentGameBoard.CurrentEnabledPlayer = CurrentGameBoard.Players[0];
            }
            return CurrentGameBoard.CurrentEnabledPlayer;
        }
    }
}
