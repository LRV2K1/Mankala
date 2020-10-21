using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;

namespace Mankala
{
    public class View
    {
        public View() { }

        public void Draw(Pit[] board, Player player)
        {

        }

        public void Draw(Player[] players)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Players " + players.Length);
            Console.ResetColor();
        }
    }
}
