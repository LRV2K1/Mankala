using Mankala.Pits;
using Mankala.Rules;

namespace Mankala.Factory
{
    public abstract class GameFactory
    {
        public GameFactory() { }


        public abstract Pit[] MakeBoard(int n);

        public abstract Ruleset MakeRuleSet();

        public virtual Player[] MakePlayers(Pit[] board)
        {
            //make players
            Player[] players = new Player[2];
            players[0] = new Player("Player 1");
            players[1] = new Player("Player 2");

            return players;
        }

        public Score MakeScore()
        {
            return new Score();
        }
    }
}

/* changes from design doc:
 * MakeBoard now takes a number of pits as argument and returns the pit array
 * MakeRuleset returns the ruleset
 * MakePlayers returns the player array
 * MakeScore returns the score object */