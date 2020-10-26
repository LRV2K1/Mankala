using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Mankala.Pits;

namespace Mankala
{
    public class View
    {
        static Pit[] board;
        Player currentPlayer;

        public View(Pit[] gameboard) 
        {
            board = gameboard;
        }

        public void Draw(Player player)
        {
            currentPlayer = player;

            List<NormalPit> playerpits = player.pits.ToList();

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
                    DrawPit(board[i], (board.Length / 2 - i - 1) * 7, 2);
                else
                    DrawPit(board[i], (i - board.Length / 2) * 7, 8);
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

        public void DrawString(string s)
        {
            Console.Clear();
            Console.Write(s);
            Console.ResetColor();
        }

        private void DrawString(string s, int left, int top)
        {

        }

        private void DrawPit(Pit pit, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("+-----+");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("|     |");
            Console.SetCursorPosition(left, top + 2);
            Console.Write("|  " + pit.stones + "  |");
            Console.SetCursorPosition(left, top + 3);
            Console.Write("|     |");
            Console.SetCursorPosition(left, top + 4);
            Console.Write("+-----+");
        }

        public static void Update()
        {
        }
    }
}
