using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Controller
    {
        private const int maxRowSlots = 3;

        private bool hasWinner;

        private Player p1, p2;
        private GameStates gameState;
        private Board board;
        private IView view;

        public Controller(Player p1, Player p2, Board board)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.board = board;
        }

        public void Run(IView view)
        {
            string input;
            this.view = view;

            string[,] values = DefineBoard();
            view.PrintBoard(values);

            Player currentPlayer = p1;

            do
            {
                bool hasPlayed = false;

                input = view.ActionSelection(currentPlayer);

                IEnumerable<string> validPositions = new List<string>();
                validPositions = UpdateValidPositions();

                foreach (string value in validPositions)
                {
                    if (input == value)
                    {
                        hasPlayed = true;
                        UpdateSlot(input, currentPlayer);

                        values = DefineBoard();
                        view.PrintBoard(values);
                        board.CheckSlots();
                        
                        currentPlayer = SwitchPlayer(currentPlayer);
                    }
                }

                if (!hasPlayed)
                    view.InvalidOption();
            }
            while(!board.IsFull && !hasWinner);

            if (!hasWinner)
                gameState = GameStates.Draw;
            else
                if (currentPlayer == p1)
                    gameState = GameStates.P2Win;
                else
                    gameState = GameStates.P1Win;

            view.EndGame(gameState);
        }

        private IEnumerable<string> UpdateValidPositions()
        {
            for (int i = 0; i < maxRowSlots; i++)
            {
                for (int j = 0; j < maxRowSlots; j++)
                {
                    if (!board.SlotMatrix[i, j].IsUsed)
                    {
                        yield return board.SlotMatrix[i, j].Value;
                    }
                }
            }
        }

        private string[,] DefineBoard()
        {   
            string[,] values = new string[maxRowSlots, maxRowSlots];
            
            for (int i = 0; i < maxRowSlots; i++)
            {
                for (int j = 0; j < maxRowSlots; j++)
                {
                    if (board.SlotMatrix[i, j].IsUsed)
                        values[i, j] = board.SlotMatrix[i, j].Value;
                    else
                        values[i, j] = board.SlotMatrix[i, j].ToString();
                }
            }

            return values;
        }

        private void UpdateSlot(string position, Player currentPlayer)
        {
            string[] stringIgnore = new string[] {" ", ","};
            int count = 2;
            string[] coordinates = position.Split(
                stringIgnore, count, StringSplitOptions.RemoveEmptyEntries);

            int x = Int32.Parse(coordinates[0]);
            int y = Int32.Parse(coordinates[1]);

            board.SlotMatrix[x, y].UpdateSlot(currentPlayer.Symbol);
            CheckWinCondition(x, y, currentPlayer);
        }

        private void CheckWinCondition(int x, int y, Player currentPlayer)
        {
                hasWinner = board.CheckLine(x, currentPlayer);
                if (!hasWinner)
                    hasWinner = board.CheckColumn(y, currentPlayer);
                if (!hasWinner)
                    hasWinner = board.CheckDiagonal(x, y, currentPlayer);
        }

        private Player SwitchPlayer(Player currentPlayer)
        {
            if (currentPlayer == p1)
                return p2;
            else
                return p1;
        }

        private void CheckBoardStatus()
        {
            bool isFull = false;

            foreach (Slot slot in board.Slots)
            {
                if (slot.IsUsed)
                    isFull = true;
            }

            if (isFull == true)
                hasWinner = true;
        }
    }
}

    