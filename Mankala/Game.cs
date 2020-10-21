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
            view = new View();
        }

        public void MakeGame()
        {
            GameFactory factory = new WariFactory();
            board = factory.MakeBoard(5);
            players = factory.MakePlayers(board);
            score = factory.MakeScore();
            ruleset = factory.MakeRuleSet();

            currentPlayer = 0;
        }

        public void Run()
        {
            while (!InputHelper.KeyPressed('Q'))
            {
                view.Draw(board, players[currentPlayer]);
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
