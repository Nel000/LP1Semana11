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

        public void PrintBoard(string[] values)
        {
            Console.WriteLine();

            Console.WriteLine($" {values[0]} | {values[1]} | {values[2]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {values[3]} | {values[4]} | {values[5]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {values[6]} | {values[7]} | {values[8]} ");

            Console.WriteLine();
        }

        public int ActionSelection(Player currentPlayer)
        {   
            Console.WriteLine($"{currentPlayer.ToString()}: " 
                + "Select one of the numbered positions make a move");
            Console.Write("> ");

            return int.Parse(Console.ReadLine());
        }

        public void UpdateBoard()
        {

        }

        public void InvalidOption()
        {
            Console.WriteLine("Invalid option! Press any key to continue...");
            Console.Read();
        }
    }
}