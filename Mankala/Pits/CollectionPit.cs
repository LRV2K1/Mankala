using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala.Pits
{
    public class CollectionPit : ICollector
    {
        public int stones { get; set; }

        public CollectionPit() { }

        public int GetStoneScore()
        {
            return stones;
        }

        public void CollectStones(int n)
        {
            stones += n;
        }
    }
}
