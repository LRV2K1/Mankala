using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Mankala.Pits;

namespace Mankala
{
    public class View
    {
        public View() { }

        public void Draw(Pit[] board, Player player)
        {
            List<Pit> playerpits = player.pits.ToList();

            Console.Clear();

            Console.WriteLine(player.name);

            for (int i = 0; i < board.Length; i++)
            {
                if (playerpits.Contains(board[i]))
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                if (board[i] is HomePit)
                    Console.ForegroundColor = ConsoleColor.Blue;

                if (i < board.Length / 2)
                    DrawPit(board[i], i * 5, 1);
                else
                    DrawPit(board[i], (i - board.Length / 2) * 5, 4);
            }

            Console.ResetColor();
        }

        public void Draw(Player[] players)
        {
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Players " + players.Length);
            Console.ResetColor();
        }

        private void DrawPit(Pit pit, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("+---+");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("| " + pit.stones + " |");
            Console.SetCursorPosition(left, top + 2);
            Console.Write("+---+");
        }
    }
}
