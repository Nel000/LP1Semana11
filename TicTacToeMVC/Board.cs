using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Board
    {
        private int size;

        public Slot[] slots { get; private set; }

        public bool GameOver{ get; private set; }

        public Board()
        {
            size = 9;
            slots = new Slot[size];
        }

        public void CheckWinCondition()
        {

        }
    }
}