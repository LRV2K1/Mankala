using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;
using Mankala.Rules;

namespace Mankala
{
    public class Player
    {
        public string name;
        public ICollector collector;
        public Pit[] pits;

        public Player(string name)
        {
            this.name = name;
        }

        public void Move(Ruleset rules)
        {
        }
    }
}
