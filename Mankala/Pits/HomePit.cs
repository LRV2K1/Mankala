using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala.Pits
{
    public class HomePit : Pit ,ICollector
    {
        int ICollector.stones { get; set; }

        public HomePit(int stones)
            : base(stones)
        {
        }

        int ICollector.GetStoneScore()
        {
            return 0;
        }

        void ICollector.CollectStones(int n)
        {

        }
    }
}
