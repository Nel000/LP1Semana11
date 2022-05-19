using System;

namespace TicTacToeMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();

            Controller controller = new Controller(player1, player2);

            IView view = new View(controller);

            controller.Run(view);
        }
    }
}
