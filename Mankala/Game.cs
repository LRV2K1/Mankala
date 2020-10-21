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
        int currentPlayer;
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
            currentPlayer = 0;

            ruleset = new WariRule();

            view = new View();
        }

        public void Run()
        {
        }

        private void NextPlayer()
        {
            currentPlayer++;
            currentPlayer %= players.Length;
        }

        private void Score()
        {

        }
    }
}
