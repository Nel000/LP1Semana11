using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public interface IView
    {
        void PrintBoard();
        int ActionSelection(Player currentPlayer);
        void UpdateBoard();
        void InvalidOption();
    }
}