using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class Controller
    {
        private List<Player> players;

        public Controller(List<Player> players)
        {
            this.players = players;
        }
    }
}