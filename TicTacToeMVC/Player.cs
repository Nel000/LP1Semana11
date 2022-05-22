using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Player
    {
        private int num;

        public string Symbol { get; private set; }

        public Player(int num, string symbol)
        {
            this.num = num;
            Symbol = symbol;
        }

        public override string ToString()
        {
            return $"Player {num}";
        }
    }
}