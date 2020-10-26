using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Pits;
using Mankala.Rules;

namespace Mankala.Factory
{
    class MankalaFactory : GameFactory
    {
        public MankalaFactory()
            : base() { }

        public override Pit[] MakeBoard(int n)
        {
            NormalPit[] p1 = new NormalPit[n];
            NormalPit[] p2 = new NormalPit[n];

            //construct pits
            for (int i = 0; i < n; i++)
            {
                p1[i] = new NormalPit(4);
                p2[i] = new NormalPit(4);

                //connect pits.
                if (i > 0)
                {
                    p1[i - 1].next = p1[i];
                    p2[i - 1].next = p2[i];
                }
            }

            //connect opposite pits
            for (int i = 0; i < n; i++)
            {
                p1[i].opposite = p2[n-i-1];
                p2[i].opposite = p1[n-i-1];
            }

            //make homepits
            HomePit hp1 = new HomePit(0);
            HomePit hp2 = new HomePit(0);

            //connect homepist, and ends
            p1[p1.Length - 1].next = hp1;
            hp1.next = p2[0];
            p2[p2.Length - 1].next = hp2;
            hp2.next = p1[0];

            //convert to one board array
            Pit[] board = new Pit[2 * n + 2];
            board[n] = hp1;
            board[2*n + 1] = hp2;
            for (int i = 0; i < n; i++)
            {
                board[i] = p1[i];
                board[i + n + 1] = p2[i];
            }

            return board;
        }

        public override Ruleset MakeRuleSet()
        {
            return new MankalaRule();
        }

        public override Player[] MakePlayers(Pit[] board)
        {
            Player[] players = base.MakePlayers(board);

            //make player pits
            players[0].pits = new NormalPit[board.Length / 2 - 1];
            players[1].pits = new NormalPit[board.Length / 2 - 1];

            //link homepits
            players[0].collector = (board[board.Length / 2 - 1] as HomePit);
            players[1].collector = (board[board.Length - 1] as HomePit);

            //link player pits
            for (int i = 0; i < board.Length / 2 - 1; i++)
            {
                players[0].pits[i] = (board[i] as NormalPit);
                board[i].owner = players[0];
                players[1].pits[i] = (board[i + board.Length / 2] as NormalPit);
                board[i + board.Length / 2].owner = players[1];
            }

            return players;
        }

    }
}
