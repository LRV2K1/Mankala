using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;
using Mankala.Rules;

namespace Mankala.Factory
{
    public class WariFactory : GameFactory
    {
        public WariFactory()
            : base() { }

        public override Pit[] MakeBoard(int n)
        {
            NormalPit[] p1 = new NormalPit[n];
            NormalPit[] p2 = new NormalPit[n];
            for (int i = 0; i < n; i++)
            {
                p1[i] = new NormalPit(4);
                p2[i] = new NormalPit(4);

                if (i > 0)
                {
                    p1[i - 1].next = p1[i];
                    p2[i - 1].next = p2[i];
                }
                p1[i].opposite = p2[i];
                p2[i].opposite = p1[i];
            }

            p1[p1.Length - 1].next = p2[0];
            p2[p2.Length - 1].next = p1[0];

            Pit[] board = new Pit[2 * n];
            for (int i = 0; i < n; i++)
            {
                board[i] = p1[i];
                board[i + n] = p2[i];
            }

            return board;
        }

        public override Ruleset MakeRuleSet()
        {
            return new WariRule();
        }

        public override Player[] MakePlayers(Pit[] board)
        {
            Player[] players = base.MakePlayers(board);

            players[0].pits = new Pit[board.Length / 2];
            players[1].pits = new Pit[board.Length / 2];

            players[0].collector = new CollectionPit();
            players[1].collector = new CollectionPit();

            for (int i = 0; i < board.Length/2; i++)
            {
                players[0].pits[i] = board[i];
                players[1].pits[i] = board[i + board.Length / 2];
            }

            return players;
        }
    }
}
