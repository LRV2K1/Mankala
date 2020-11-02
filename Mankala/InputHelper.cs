using System;
using System.Collections.Generic;
using System.Text;

namespace Mankala
{
    static class InputHelper
    {
        public static int GetNumber()
        {
            string number = "";
            char c = GetKey();
            
            while ((int)c != 13)
            {
                if ((int)c == 8 && number.Length > 0)
                {
                    number = number.Remove(number.Length - 1);
                    Console.Write(" \b");
                }

                int k = (int)Char.GetNumericValue(c);

                if (k >= 0 && number.Length < 5)
                {
                    number += c;
                    Console.Write(c);
                }
                c = GetKey();
            }

            for (int i = 0; i < number.Length; i++)
                Console.Write("\b");
            for (int i = 0; i < number.Length; i++)
                Console.Write(" ");
            for (int i = 0; i < number.Length; i++)
                Console.Write("\b");

            if (number == "")
                return -1;
            else
                return int.Parse(number);
        }

        public static char GetKey()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            if ((int)cki.KeyChar != 8)
                Console.Write("\b \b");
            return cki.KeyChar;
        }
    }
}

/* changes from design doc:
 * new method getnumber, allows for numbers above 9 to be picked, helps with extensibility for higher pit sizes */
