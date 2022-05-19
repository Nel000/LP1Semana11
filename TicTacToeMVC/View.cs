using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class View : IView
    {
        private Controller controller;
        
        public View (Controller controller)
        {
            this.controller = controller;
        }

        public int ActionSelection()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}