using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class Controller
    {
        private List<Player> players;

        private IView view;

        public Controller(List<Player> players)
        {
            this.players = players;
        }

        public void Run(IView view)
        {
            this.view = view;

            string input;
            
            do
            {
                input = view.MainMenu();

                switch (input)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        DefineOrderList(playerList);
                        break;
                    case "3":
                        ShowPlayersWithScore();
                        break;
                    case "E":
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.Read();
            }
            while (input != "E");
        }

        private void InsertPlayer()
        {
            (string name, int score) = view.AskForPlayer();

            Player p = new Player(name, score);

            players.Add(new Player(name, score));
        }

        private void ShowPlayersWithScore()
        {
            IEnumerable<Player> highScorePlayers;
            int minScore = view.AskForMinScore();
            highScorePlayers = GetPlayersWithScoreGreaterThan(minScore);
            view.ShowPlayers(highScorePlayers);
        }

        private void DefineOrderList(IEnumerable<Player> playerCollection)
        {
            IComparer<Player> comp;

            string input;

            bool showing = true;

            do
            {
                input = view.AskForListType();

                switch (input)
                {
                    case "1":
                        playerList.Sort();
                        showing = false;
                        break;
                    case "2":
                        comp = new CompareByName(true);
                        playerList.Sort(comp);
                        showing = false;
                        break;
                    case "3":
                        comp = new CompareByName(false);
                        playerList.Sort(comp);
                        showing = false;
                        break;
                    default:
                        Console.WriteLine("!!! Unknown option !!!");
                        break;
                }
            }
            while (showing);

            view.ShowPlayers(playerCollection);
        }
    }
}