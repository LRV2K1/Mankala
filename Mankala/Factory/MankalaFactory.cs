using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;
using Mankala.Rules;

namespace Mankala.Factory
{
    class MankalaFactory : GameFactory
    {
        public MankalaFactory()
            : base() { }

        public override Pit[] MakeBoard(int n)
        {
            throw new NotImplementedException();
        }

        public override Ruleset MakeRuleSet()
        {
            throw new NotImplementedException();
        }

        public override Player[] MakePlayers(Pit[] board)
        {
            throw new NotImplementedException();
        }

    }
}
