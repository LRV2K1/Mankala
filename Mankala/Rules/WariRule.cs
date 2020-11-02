using Mankala.Pits;

namespace Mankala.Rules
{
    public class WariRule : Ruleset
    {
        public WariRule()
            : base() { }

        public override void MoveEnd(Pit pit, Player player)
        {
            //end in pit not of player
            if (pit.owner != player)
            {
                if (pit.stones > 1 && pit.stones < 4)
                {
                    //take stones
                    player.collector.CollectStones((pit as NormalPit).takeStones());
                }
            }
        }

        public override bool NextPlayer(Pit pit, Player player)
        {
            return true;
        }
    }
}
