using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class View : IView
    {
        private Controller controller;
        
        public View (Controller controller)
        {
            this.controller = controller;
        }

        public void PrintBoard(string[,] values)
        {
            Console.WriteLine();

            Console.WriteLine(
                " {0,3} | {1,3} | {2,3} ",
                values[0, 0], values[0, 1], values[0, 2]);
            Console.WriteLine("-----------------");
            Console.WriteLine(
                " {0,3} | {1,3} | {2,3} ",
                values[1, 0], values[1, 1], values[1, 2]);
            Console.WriteLine("-----------------");
            Console.WriteLine(
                " {0,3} | {1,3} | {2,3} ",
                values[2, 0], values[2, 1], values[2, 2]);

            Console.WriteLine();
        }

        public string ActionSelection(Player currentPlayer)
        {   
            Console.WriteLine($"{currentPlayer.ToString()}: " 
                + "Select one of the numbered positions make a move");
            Console.Write("> ");

            return Console.ReadLine();
        }

        public void InvalidOption()
        {
            Console.WriteLine("Invalid option! Press any key to continue...");
            Console.Read();
        }

        public void EndGame(GameStates gameState)
        {
            Console.Write("GAME OVER");

            switch (gameState)
            {
                case GameStates.Draw:
                    Console.Write(" - It's a draw!");
                    break;
                case GameStates.P1Win:
                    Console.Write(" - Player 1 wins!");
                    break;
                case GameStates.P2Win:
                    Console.Write(" - Player 2 wins!");
                    break;
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.Read();
        }
    }
}