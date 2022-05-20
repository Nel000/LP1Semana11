using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public interface IView
    {
        void PrintBoard(string[] values);
        int ActionSelection(Player currentPlayer);
        void UpdateBoard();
        void InvalidOption();
    }
}