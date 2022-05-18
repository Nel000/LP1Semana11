using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class Program
    {
        private static void Main()
        {
            List<Player> playerList = new List<Player>()
            {
                new Player("Marco", 200),
                new Player("Verde", 250)
            };

            Controller controller = new Controller(playerList);

            IView view = new UglyView(controller, playerList);

            controller.Run(view);
        }
    }
}
