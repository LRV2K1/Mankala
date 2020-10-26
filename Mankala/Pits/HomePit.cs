using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala.Pits
{
    public class HomePit : Pit ,ICollector
    {
        int ICollector.stones 
        { 
            get { return stones; }
            set { stones = value; }
        }

        public HomePit(int stones)
            : base(stones)
        {
        }

        int ICollector.GetStoneScore()
        {
            return stones;
        }

        void ICollector.CollectStones(int n)
        {
            PlaceStone(n);
        }
    }
}
