using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Slot
    {
        public bool IsUsed { get; private set; }

        public string Move { get; private set; }

        public void UpdateSlot(string move)
        {
            IsUsed = true;
            Move = move;
        }
    }
}