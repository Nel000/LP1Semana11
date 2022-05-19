using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeMVC
{
    public class Controller
    {
        private Player p1, p2;
        private IView view;

        public Controller(Player p1, Player p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void Run(IView view)
        {
            this.view = view;
        }
    }
}