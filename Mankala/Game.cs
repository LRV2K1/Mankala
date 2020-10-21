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
            players = new Player[2];
            players[0] = new Player();
            players[1] = new Player();
            currentPlayer = players[0];

            ruleset = new WariRule();
        }

        public void Run()
        {
        }

        private void NextPlayer()
        {
            if (currentPlayer == players[0])
                currentPlayer = players[1];
            else
                currentPlayer = players[0];
        }

        private void Score()
        {

        }
    }
}
