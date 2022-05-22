using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Board
    {
        private const int size = 9;
        private const int maxSlots = 3;

        public Slot[] Slots { get; private set; }
        public Slot[,] SlotMatrix { get; private set; }

        public bool IsFull{ get; private set; }

        public Board()
        {
            Slots = new Slot[size];
            SlotMatrix = new Slot[maxSlots, maxSlots];

            for (int i = 0; i < Slots.Length; i++)
            {
                Slots[i] = new Slot((i + 1).ToString());
            }

            for (int i = 0; i < maxSlots; i++)
            {
                for (int j = 0; j < maxSlots; j++)
                {
                    SlotMatrix[i, j] = new Slot($"{i},{j}");
                }
            }
        }

        public void CheckSlots()
        {
            bool hasEmptySlots = false;

            foreach (Slot slot in Slots)
            {
                if (!slot.IsUsed)
                    hasEmptySlots = true;
            }

            if (!hasEmptySlots)
                IsFull = true;
            else
                IsFull = false;
        }
    }
}