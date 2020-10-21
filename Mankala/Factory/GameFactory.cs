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

        public abstract Player[] MakePlayers(Pit[] board);

        public Score MakeScore()
        {
            return new Score();
        }
    }
}
