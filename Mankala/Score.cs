using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala
{
    public class Score
    {
        public int calculateScore(Player p)
        {
            return p.collector.GetStoneScore();
        }
    }
}
