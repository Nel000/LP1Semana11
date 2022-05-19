using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            Player player1 = new Player();
            Player player2 = new Player();

            Controller controller = new Controller(player1, player2, board);

            IView view = new View(controller);

            controller.Run(view);
        }
    }
}
