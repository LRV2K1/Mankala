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
        static Player currentPlayer;

        public View(Pit[] gameboard) 
        {
            board = gameboard;
        }

        public void Draw(Player player)
        {
            currentPlayer = player;
            Update();
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

        private static void DrawString(string s, int left, int top)
        {

        }

        private static void DrawPit(Pit pit, int left, int top)
        {
            //first lines
            Console.SetCursorPosition(left, top);
            Console.Write("+-----+");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("|     |");
            Console.SetCursorPosition(left, top + 2);

            //number of stones in pit
            string line = "|     |";
            int l = pit.stones.ToString().Length;
            line = line.Remove(3 - (l - 1) / 2, l);
            line = line.Insert(3 - (l - 1) / 2, pit.stones.ToString());
            Console.Write(line);

            //last lines
            Console.SetCursorPosition(left, top + 3);
            Console.Write("|     |");
            Console.SetCursorPosition(left, top + 4);
            Console.Write("+-----+");
        }

        public static void Update()
        {
            List<NormalPit> playerpits = currentPlayer.pits.ToList();

            //clear the console
            Console.Clear();

            Console.WriteLine(currentPlayer.name);

            int offset = 0;

            for (int i = 0; i < board.Length; i++)
            {
                if (playerpits.Contains(board[i]))
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                if (board[i] is HomePit)
                    Console.ForegroundColor = ConsoleColor.Blue;

                if (i < board.Length / 2)
                    DrawPit(board[i], (board.Length / 2 - i - 1) * 7, 3);
                else
                    DrawPit(board[i], (i - board.Length / 2 + offset) * 7, 9);

                if (board[i] is HomePit)
                    offset++;
            }

            //end write
            Console.Write("\n");
            Console.ResetColor();
        }
    }
}
