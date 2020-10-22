using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Mankala.Pits;

namespace Mankala.Rules
{
    public class MankalaRule : Ruleset
    {
        public MankalaRule()
            : base() { }


        public override void MoveEnd(Pit pit, Player player)
        {
            List<NormalPit> playerpits = player.pits.ToList();

            if (pit is HomePit && pit == player.collector)
            {
                player.Move(this);
                return;
            }

            if ((pit as NormalPit).opposite.stones != 0 && playerpits.Contains(pit))
            {
                player.collector.CollectStones((pit as NormalPit).opposite.stones + pit.stones);
                pit.stones = 0;
                (pit as NormalPit).opposite.stones = 0;
            }
        }

        public override bool NextPlayer(Pit pit, Player player)
        {
            if (pit is HomePit && pit == player.collector)
                return true;

            if (pit.stones > 0)
                return false;

            return true;
        }
    }
}
