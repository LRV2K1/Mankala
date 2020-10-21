using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala.Pits
{
    public class CollectionPit : ICollector
    {
        public int stones { get; set; }

        public CollectionPit()
        {
        }

        public int GetStoneScore()
        {
            return 0;
        }

        public void CollectStones(int n)
        {

        }
    }
}
