using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;

namespace Mankala.Rules
{
    public abstract class Ruleset
    {
        public Ruleset()
        {

        }

        public abstract void MoveEnd(Pit pit, Player player);

        public abstract bool NextPlayer(Pit pit, Player player);

        public virtual bool GameFinished(Player[] players)
        {
            return true;
        }

        public virtual bool HasMoves(Player player)
        {
            return true;
        }
    }
}
