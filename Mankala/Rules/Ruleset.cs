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

        public virtual bool GameFinished(Player[] players, int currentplayer)
        {
            return !HasMoves(players[currentplayer]);
        }

        public virtual bool HasMoves(Player player)
        {
            //check if all pits are empty
            for (int i = 0; i < player.pits.Length; i++)
            {
                if (player.pits[i].stones > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
