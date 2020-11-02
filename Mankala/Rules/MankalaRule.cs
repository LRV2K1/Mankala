using Mankala.Pits;

namespace Mankala.Rules
{
    public class MankalaRule : Ruleset
    {
        public MankalaRule()
            : base() { }


        public override void MoveEnd(Pit pit, Player player)
        {
            //end in own homepit
            if (pit is HomePit)
            {
                //go again
                if (pit == player.collector)
                    player.Move(this);
                return;
            }

            //end in own pit, and opposite pit contains stones
            if ((pit as NormalPit).opposite.stones != 0 && pit.owner == player)
            {
                //take stones, and place them in own homepit
                player.collector.CollectStones((pit as NormalPit).opposite.takeStones() + (pit as NormalPit).takeStones());
            }
        }

        public override bool NextPlayer(Pit pit, Player player)
        {
            //end in own homepit
            if (pit is HomePit)
                return true;

            //end in a non empty pit
            if (pit.stones > 0)
                return false;

            //other
            return true;
        }
    }
}
