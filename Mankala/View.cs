﻿using System;
using Mankala.Pits;

namespace Mankala
{
    public class View
    {
        static Pit[] board;
        static Player currentPlayer;

        public void setBoard(Pit[] gameboard)
        {
            board = gameboard;
        }

        public void Draw(Player player)
        {
            currentPlayer = player;
            Update();
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Draw(Player[] players)
        {
            Clear();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Players " + players.Length);
            Console.ResetColor();
        }

        public void DrawString(string s)
        {
            Console.Write(s + "\n");
            Console.ResetColor();
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
            //clear the console
            Console.Clear();

            //write currentplayer name
            Console.WriteLine(currentPlayer.name);

            //offset for homepits
            int offset = 0;

            //draw all pits
            for (int i = 0; i < board.Length; i++)
            {
                //if it is the current players pit
                if (board[i].owner == currentPlayer)
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                //if it is a homepit
                if (board[i] is HomePit)
                    Console.ForegroundColor = ConsoleColor.Blue;

                if (i < board.Length / 2)
                {
                    Console.SetCursorPosition((board.Length / 2 - i - 1) * 7 + 3, 2);
                    Console.Write(i);
                    DrawPit(board[i], (board.Length / 2 - i - 1) * 7, 3);
                }
                else
                {
                    Console.SetCursorPosition((i - board.Length / 2 + offset) * 7 + 3, 14);
                    Console.Write(i - board.Length/2);
                    DrawPit(board[i], (i - board.Length / 2 + offset) * 7, 9);
                }

                if (board[i] is HomePit)
                    offset++;
            }

            //end write
            Console.Write("\n");
            Console.ResetColor();
        }
    }
}
/* changes from design doc:
 * class almost entirely new because the view was not elaborated on in the original design */
