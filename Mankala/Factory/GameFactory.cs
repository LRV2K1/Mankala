using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;
using Mankala.Rules;

namespace Mankala.Factory
{
    public abstract class GameFactory
    {
        public GameFactory() { }


        public abstract Pit[] MakeBoard(int n);

        public abstract Ruleset MakeRuleSet();

        public virtual Player[] MakePlayers(Pit[] board)
        {
            Player[] players = new Player[2];
            players[0] = new Player("Player 1");
            players[1] = new Player("Player 2");

            return players;
        }

        public Score MakeScore()
        {
            return new Score();
        }
    }
}
