using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Controller
    {
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

            Player currentPlayer = p1;

            do
            {
                view.PrintBoard();
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
            while(!board.GameOver);
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

        private void CheckWinCondition()
        {

        }
    }
}

    