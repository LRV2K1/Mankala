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

        public Game() { }

        public void MakeGame()
        {
            view = new View();
            GameFactory factory = null;

            bool modeSelected = false;


            while (!modeSelected)
            {
                view.DrawString("enter 1 for mankala and 2 for wari");
                int mode = 0;
                try { mode = (int)Char.GetNumericValue(InputHelper.GetKey()); view.Clear(); }
                catch { view.DrawString("not a valid game mode"); }
                switch (mode)
                {
                    case 1:
                        factory = new MankalaFactory(); modeSelected = true; break;
                    case 2:
                        factory = new WariFactory(); modeSelected = true; break;
                    default:
                        view.DrawString("not a valid game mode"); break;
                }
            }
           
            board = factory.MakeBoard(6);
            players = factory.MakePlayers(board);
            score = factory.MakeScore();
            ruleset = factory.MakeRuleSet();

            view.setBoard(board);

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
            view.Draw(players[currentPlayer]);
            Score();
        }

        private void NextPlayer()
        {
            currentPlayer++;
            currentPlayer %= players.Length;
        }

        private void Score()
        {
            int p1score = score.calculateScore(players[0]);
            int p2score = score.calculateScore(players[1]);

            view.DrawString("player 1 scored: " + p1score + " and player 2 scored: " + p2score);
            view.DrawString("press any key to close the program");
            InputHelper.GetKey();
        }
    }
}
