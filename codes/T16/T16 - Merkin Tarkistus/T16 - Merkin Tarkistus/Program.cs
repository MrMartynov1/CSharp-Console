using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16___Merkin_Tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.Write("Syötä jokin merkki: ");

            cki = Console.ReadKey();
            Console.WriteLine("\n"+cki.KeyChar);
            char merkki = cki.KeyChar;

            if (Char.IsDigit(merkki))
            {
                Console.WriteLine("Se on numero.");
            }

            else if (Char.IsLetter(merkki))
            {
                Console.WriteLine("Se on kirjain.");

                if (Char.IsLower(merkki))
                {
                    Console.WriteLine("Se on pieni kirjain.");
                }
                else if (Char.IsUpper(merkki))
                {
                    Console.WriteLine("Se on iso kirjain.");
                }
            }

            else if (Char.IsSymbol(merkki))
            {
                Console.WriteLine("Se on erikoismerkki.");
            }

            else if (Char.IsWhiteSpace(merkki))
            {
                Console.WriteLine("Se on tyhjä.");
            }

            else
            {
                Console.WriteLine("Se on merkki.");
            }

            Console.ReadKey();
        }
    }
}