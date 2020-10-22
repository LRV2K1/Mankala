using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Mankala.Pits;

namespace Mankala.Rules
{
    public class WariRule : Ruleset
    {
        public WariRule()
            : base() { }

        public override void MoveEnd(Pit pit, Player player)
        {
            List<NormalPit> playerpits = player.pits.ToList();

            if (!playerpits.Contains(pit))
            {
                if (pit.stones > 1 && pit.stones < 4)
                {
                    player.collector.CollectStones(pit.stones);
                    pit.stones = 0;
                }
            }
        }

        public override bool NextPlayer(Pit pit, Player player)
        {
            return true;
        }
    }
}
