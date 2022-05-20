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

        public void PrintBoard()
        {
            Console.WriteLine();

            Console.WriteLine("   |   |   ");
            Console.WriteLine("-----------");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("-----------");
            Console.WriteLine("   |   |   ");

            Console.WriteLine();
        }

        public int ActionSelection(Player currentPlayer)
        {   
            Console.WriteLine($"{currentPlayer.ToString()}: " 
                + "Select a position between 1 and 9");
            Console.Write("> ");

            return int.Parse(Console.ReadLine());
        }

        public void UpdateBoard()
        {

        }

        public void InvalidOption()
        {

        }
    }
}