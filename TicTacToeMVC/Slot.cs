using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Slot
    {
        private int number;

        public bool IsUsed { get; private set; }

        public string Value { get; private set; }

        public Slot(int number)
        {
            this.number = number;
            Value = number.ToString();
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