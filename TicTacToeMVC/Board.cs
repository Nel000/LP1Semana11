using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Board
    {
        private int size;

        public Slot[] Slots { get; private set; }

        public bool IsFull{ get; private set; }

        public Board()
        {
            size = 9;
            Slots = new Slot[size];

            for (int i = 0; i < Slots.Length; i++)
            {
                Slots[i] = new Slot(i + 1);
            }
        }

        public void CheckWinCondition()
        {

        }
    }
}