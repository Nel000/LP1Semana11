using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public interface IView
    {
        void PrintBoard(string[,] values);
        string ActionSelection(Player currentPlayer);
        void InvalidOption();
        void EndGame(GameStates gameState);
    }
}