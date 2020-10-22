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
        public NormalPit[] pits;

        public Player(string name)
        {
            this.name = name;
        }

        public void Move(Ruleset rules)
        {
            char c = InputHelper.GetKey();
            while ((int)Char.GetNumericValue(c) >= pits.Length || (int)Char.GetNumericValue(c) < 0)
            {
                c = InputHelper.GetKey();
            }

            Pit p = pits[(int)Char.GetNumericValue(c)];

            do
            {
                int n = (p as NormalPit).takeStones();
                while (n > 0)
                {
                    p = p.next;
                    p.PlaceStone(1);
                    n--;
                }
                rules.MoveEnd(p, this);
            }
            while (!rules.NextPlayer(p, this));
        }
    }
}
