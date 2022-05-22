using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            Player player1 = new Player(1, "X");
            Player player2 = new Player(2, "O");

            Controller controller = new Controller(player1, player2, board);

            IView view = new View(controller);

            controller.Run(view);
        }
    }
}
