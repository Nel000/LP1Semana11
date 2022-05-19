using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Controller
    {
        private Player p1, p2;
        private Board board;
        private IView view;

        private bool gameOver;

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

            gameOver = false;

            do
            {
                input = view.ActionSelection();

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
                        // view.UpdateBoard(input);
                        break;
                    default:
                        // view.InvalidOption();
                        break;
                }

                // CheckWinCondition();
            }
            while(!gameOver);
        }
    }
}