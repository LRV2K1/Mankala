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

            //end in own homepit
            if (pit is HomePit && pit == player.collector)
            {
                //go again
                player.Move(this);
                return;
            }

            //end in own pit, and opposite pit contains stones
            if ((pit as NormalPit).opposite.stones != 0 && playerpits.Contains(pit))
            {
                //take stones, and place them in own homepit
                player.collector.CollectStones((pit as NormalPit).opposite.stones + pit.stones);
                pit.stones = 0;
                (pit as NormalPit).opposite.stones = 0;
            }
        }

        public override bool NextPlayer(Pit pit, Player player)
        {
            //end in own homepit
            if (pit is HomePit && pit == player.collector)
                return true;

            //end in a non empty pit
            if (pit.stones > 0)
                return false;

            //other
            return true;
        }
    }
}
