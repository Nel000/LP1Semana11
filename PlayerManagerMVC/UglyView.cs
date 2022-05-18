using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class UglyView : IView
    {
        private Controller controller;
        private List<Player> players;

        public UglyView(Controller controller, List<Player> players)
        {
            this.controller = controller;
            this.players = players;
        }
    }
}