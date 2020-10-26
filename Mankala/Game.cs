using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Rules;
using Mankala.Pits;
using Mankala.Factory;

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
            GameFactory factory = new WariFactory();
            board = factory.MakeBoard(10);
            players = factory.MakePlayers(board);
            score = factory.MakeScore();
            ruleset = factory.MakeRuleSet();

            view = new View(board);

            currentPlayer = 0;
        }

        public void Run()
        {
            while (!ruleset.GameFinished(players, currentPlayer))
            {
                view.Draw(players[currentPlayer]);
                players[currentPlayer].Move(ruleset);
                NextPlayer();
            }
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
