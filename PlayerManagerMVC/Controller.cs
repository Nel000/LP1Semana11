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

            int input;
            
            do
            {
                input = view.MainMenu();

                switch (input)
                {
                    case 1:
                        InsertPlayer();
                        break;
                    case 2:
                        DefineOrderList(players);
                        break;
                    case 3:
                        ShowPlayersWithScore();
                        break;
                    case 0:
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while (input != 0);
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

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (Player player in players)
            {
                if (player.Score >= minScore)
                {
                    yield return player;
                }
            }
        }

        private void DefineOrderList(IEnumerable<Player> playerCollection)
        {
            IComparer<Player> comp;

            int input;

            bool showing = true;

            do
            {
                input = view.AskForListType();

                switch (input)
                {
                    case 1:
                        players.Sort();
                        showing = false;
                        break;
                    case 2:
                        comp = new CompareByName(true);
                        players.Sort(comp);
                        showing = false;
                        break;
                    case 3:
                        comp = new CompareByName(false);
                        players.Sort(comp);
                        showing = false;
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while (showing);

            view.ShowPlayers(playerCollection);
        }
    }
}
