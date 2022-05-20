using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Player
    {
        private int num;

        public Player(int num)
        {
            this.num = num;
        }

        public override string ToString()
        {
            return $"Player {num}";
        }
    }
}