using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Slot
    {
        private string number;

        public bool IsUsed { get; private set; }

        public string Value { get; private set; }

        public Slot(string number)
        {
            this.number = number;
            Value = number;
        }

        public void UpdateSlot(string move)
        {
            IsUsed = true;
            Value = move;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}