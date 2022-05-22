namespace TicTacToeMVC
{
    public class Board
    {
        private const int size = 9;
        private const int maxSlots = 3;

        public Slot[,] SlotMatrix { get; private set; }

        public bool IsFull{ get; private set; }

        public Board()
        {
            SlotMatrix = new Slot[maxSlots, maxSlots];

            for (int i = 0; i < maxSlots; i++)
            {
                for (int j = 0; j < maxSlots; j++)
                {
                    SlotMatrix[i, j] = new Slot($"{i},{j}");
                }
            }
        }

        public bool CheckLine(int x, Player currentPlayer)
        {   
            int playerSlots = 0;

            for (int i = 0; i < maxSlots; i++)
            {
                if (SlotMatrix[x , i].Value == currentPlayer.Symbol)
                    playerSlots++;
            }

            if (playerSlots == 3)
                return true;

            return false;
        }

        public bool CheckColumn(int y, Player currentPlayer)
        {
            int playerSlots = 0;

            for (int i = 0; i < maxSlots; i++)
            {
                if (SlotMatrix[i, y].Value == currentPlayer.Symbol)
                    playerSlots++;
            }

            if (playerSlots == 3)
                return true;

            return false;
        }

        public bool CheckDiagonal(int x, int y, Player currentPlayer)
        {
            int playerSlots = 0;

            for (int i = 0, j = 2; i < maxSlots; i++, j--)
            {
                if (x == y)
                {
                    if (SlotMatrix[i, i].Value == currentPlayer.Symbol)
                        playerSlots++;
                }   
                else
                {
                    if (SlotMatrix[i, j].Value == currentPlayer.Symbol)
                        playerSlots++;
                }
            }

            if (playerSlots == 3)
                return true;

            return false;
        }

        public void CheckSlots()
        {
            bool hasEmptySlots = false;

            foreach (Slot slot in SlotMatrix)
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