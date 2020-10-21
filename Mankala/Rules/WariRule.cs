using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;

namespace Mankala.Rules
{
    public class WariRule : Ruleset
    {
        public WariRule()
            : base()
        {

        }

        public override void MoveEnd(Pit pit, Player player)
        {

        }

        public override bool NextPlayer(Pit pit, Player player)
        {
            return true;
        }
    }
}
