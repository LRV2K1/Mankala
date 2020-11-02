using System;

namespace Mankala
{
    class Program
    {
        Game game;

        static void Main()
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            game = new Game();
            game.MakeGame();
            game.Run();
        }
    }
}

/* changes from design doc:
 * was originally named main, now program
 * new method: Run(), separated from Main() to improve cohesion */