using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class UglyView : IView
    {
        private Controller controller;
        private List<Player> players;

        public UglyView(Controller controller, List<Player> players)
        {
            this.controller = controller;
            this.players = players;
        }

        public int MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1. Insert Player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.Write("> ");

            return int.Parse(Console.ReadLine());
        }

        public void ShowPlayers(IEnumerable<Player> players)
        {
            foreach (Player player in players)
            {
                Console.WriteLine($"-> {player}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.Read();
            Console.WriteLine();
        }

        public void InvalidOption()
        {
            Console.WriteLine("\nInvalid option! Press any key to continue...");
            Console.Read();
            Console.WriteLine();
        }

        public int AskForMinScore()
        {
            Console.WriteLine();
            Console.Write("Minimum score? > ");
            return int.Parse(Console.ReadLine());
        }

        public int AskForListType()
        {
            Console.WriteLine("1. List by score");
            Console.WriteLine("2. List alphabetically, ascending");
            Console.WriteLine("3. List alphabetically, descending");
            return int.Parse(Console.ReadLine());
        }

        public (string, int) AskForPlayer()
        {
            string name;
            int score;

            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            return (name, score);
        }
    }
}
