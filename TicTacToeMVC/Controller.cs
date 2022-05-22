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

            string[] values;

            Player currentPlayer = p1;

            do
            {
                board.CheckWinCondition();
                values = DefineBoard();
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
                        UpdateSlots(input, currentPlayer);
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
                if (board.Slots[i].IsUsed)
                    values[i] = board.Slots[i].Value;
                else
                    values[i] = board.Slots[i].ToString();
            }

            return values;
        }

        private void UpdateSlots(int position, Player currentPlayer)
        {
            board.Slots[position].UpdateSlot(currentPlayer.Symbol);
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

    