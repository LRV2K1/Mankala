using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;
using Mankala.Rules;

namespace Mankala
{
    public class Player
    {
        //player has a name, is used in player identification on the view.
        public string name;
        public ICollector collector;
        public NormalPit[] pits;

        public Player(string name)
        {
            this.name = name;
        }

        public void Move(Ruleset rules)
        {
            View.Update();

            //no moves for this player
            if (!rules.HasMoves(this))
                return;

            //get the number of the pit
            int pitnummer = InputHelper.GetNumber();
            while (pitnummer >= pits.Length || pitnummer < 0 || pits[pitnummer].stones <= 0)
            {
                pitnummer = InputHelper.GetNumber();
            }

            Pit p = pits[pitnummer];

            //take stones, and place them in the pits
            do
            {
                int n = (p as NormalPit).takeStones();
                while (n > 0)
                {
                    p = p.next;
                    p.PlaceStone(1);
                    n--;
                }

                //check the rules
                rules.MoveEnd(p, this);
            }
            //keep doing this untill it is the next player's turn
            while (!rules.NextPlayer(p, this));
        }
    }
}
/* changes from design doc:
 * new string, name, allows player to be named, currently only used for "Player 1" and "Player 2" but aids in extendability */
