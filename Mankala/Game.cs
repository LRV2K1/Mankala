using System;
using System.Collections.Generic;
using System.Text;
using Mankala.Rules;
using Mankala.Pits;

namespace Mankala
{
    public class Game
    {
        Player[] players;
        int currentPlayer;
        View view;
        Ruleset ruleset;
        Pit[] board;
        Score score;

        public Game()
        {

        }

        public void MakeGame()
        {
            players = new Player[2];
            players[0] = new Player("Player 1");
            players[1] = new Player("Player 2");
            currentPlayer = 0;

            ruleset = new WariRule();

            view = new View();

            Pit pit = new NormalPit(5);

            board = new Pit[3];
            board[0] = new HomePit(2);
            board[1] = pit;
            board[2] = new NormalPit(3);

            players[0].pits = new Pit[1];
            players[0].pits[0] = pit; 
        }

        public void Run()
        {
            view.Draw(board, players[currentPlayer]);
        }

        private void NextPlayer()
        {
            currentPlayer++;
            currentPlayer %= players.Length;
        }

        private void Score()
        {

        }
    }
}
