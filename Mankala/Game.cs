using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Rules;
using Mankala.Pits;

namespace Mankala
{
    public class Game
    {
        Player[] players;
        Player currentPlayer;
        View view;
        Ruleset ruleset;
        Pit[] board;
        Score score;

        public Game()
        {

        }

        public void MakeGame()
        {
            if (InputHelper.KeyPressed(' '))
            {
                Console.WriteLine("test");
            }
            else
            {
                Console.WriteLine("fout");
            }
        }

        public void Run()
        {
            int i = 0;
            while (true)
            {
                char key = InputHelper.GetKey();
                if (key == 'L')
                {
                    Console.WriteLine("Lourens " + i);
                    i++;
                }
                else if (key == 'Q')
                {
                    break;
                }
            }
        }

        private void NextPlayer()
        {

        }

        private void Score()
        {

        }
    }
}
