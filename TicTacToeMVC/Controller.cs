using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Controller
    {
        private bool gameOver;

        private Player p1, p2;
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
            int input;
            this.view = view;

            string[] values = DefineBoard();

            Player currentPlayer = p1;

            do
            {
                view.PrintBoard(values);
                input = view.ActionSelection(currentPlayer);

                switch (input)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        UpdateBoard(input);
                        board.CheckWinCondition();
                        currentPlayer = SwitchPlayer(currentPlayer);
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while(!board.IsFull && !gameOver);
        }

        private string[] DefineBoard()
        {   
            string[] values = new string[board.Slots.Length];
            
            for (int i = 0; i < board.Slots.Length; i++)
            {
                values[i] = board.Slots[i].ToString();
            }

            return values;
        }

        private void UpdateBoard(int position)
        {

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
                gameOver = true;
        }
    }
}

    