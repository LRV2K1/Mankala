using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala.Pits
{
    public abstract class Pit
    {
        public int stones;
        public Pit next;

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
