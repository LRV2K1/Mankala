using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala.Pits
{
    public abstract class Pit
    {
        public int stones;
        public Pit next;

        //pit has a owner, is used to check in the rules and in the colloring of the view.
        public Player owner;

        public Pit(int n) 
        {
            stones = n;
        }

        public void PlaceStone(int n)
        {
            stones += n;
        }
    }
}
