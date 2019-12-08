using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10._1___List
{

    class Program
    {

        static void Main(string[] args)
        {
            string syote;
            List<string> Names = new List<string>();
            // Console.Write("Kuinka monta oppilasta?: "); not necessary
            // int määrä = Convert.ToInt32(Console.ReadLine()); not necessary
            do
            {
                Console.Write("Lisää oppilaan nimi, 'L' lopettaa: ");
                syote = Console.ReadLine();
                if (syote != "L")
                {
                    Names.Add(syote);
                }

            } while (syote != "L");
            foreach (string oppilas in Names)
            {
                Console.WriteLine(oppilas);

            }

            Console.ReadKey();
            Console.Clear();

            Console.Write("Kuinka monta oppilasta haluat nähdä?: ");
            int luku = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < luku; i++)
            {

                Console.WriteLine(Names[i]);
            }
            Console.ReadKey();
            Console.Clear();

            Console.Write("Haluatko nähdä aakkosjärjestyksessä? [paina y] vai käänteisaakkosjärjestyksessä? [paina n]: ");
            string akk = Console.ReadLine();

            if (akk.Contains("y"))
            {
                Names.Sort();
                Console.Write("Näytetään lista aakkosjärjestyksessä:");
                Console.ReadKey();
                foreach (string oppilas in Names)
                {
                    Console.WriteLine(oppilas);

                }

                Console.ReadKey();
                Console.Clear();
            }

            else if (akk.Contains("n"))
            {
                Names.Reverse();
                Console.WriteLine("Näytetään lista käänteisaakkosjärjestyksessä:");
                Console.ReadKey();
                foreach (string oppilas in Names)
                {
                    Console.WriteLine(oppilas);

                }
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.ReadKey();
            }
        }
    }
}
