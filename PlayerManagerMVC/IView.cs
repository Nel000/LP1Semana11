using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public interface IView
    {
        string MainMenu();

        void ShowPlayers(IEnumerable<Player> players);

        void InvalidOption();

        int AskForMinScore();

        int AskForListType();

        (string, int) AskForPlayer();
    }
}