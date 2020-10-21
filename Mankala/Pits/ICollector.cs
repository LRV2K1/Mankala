using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala.Pits
{
    public interface ICollector
    {
        public int stones { get; set; }

        public int GetStoneScore();

        public void CollectStones(int n);
    }
}
