using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala
{
    static class InputHelper
    {
        public static bool KeyPressed(char c)
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.Write("\b");
            return cki.KeyChar == c;
        }

        public static char GetKey()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.Write("\b");
            return cki.KeyChar;
        }
    }
}
