using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5___Loogiset_Loogiset_Operaattorit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Paistaako aurinko? (K/E): ");
            string q1 = Console.ReadLine();

            Console.Write("Sataako? (K/E): ");
            string q2 = Console.ReadLine();

            Console.Write("Onko lämpötila >0 (K/E): ");
            string q3 = Console.ReadLine();

            if (q1 =="K" && q2=="K" && q3=="K")
            {
                Console.WriteLine("Aurinko paistaa ja vettä sataa taitaa tulla kesä.");
                Console.ReadKey();
            }
            else if (q1 == "E" && q2 == "K" && q3 == "K")
            {
                Console.WriteLine("Syksy saapui lehdet vei tuuli menneessään.");
                Console.ReadKey();
            }
            else if (q1 == "E" && q2 == "E" && q3 == "K")
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
                Console.ReadKey();
            }
            else if (q1 == "K" && q2 == "E" && q3 == "K")
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
                Console.ReadKey();
            }
            else if (q1 == "E" && q2 == "E" && q3 == "E")
            {
                Console.WriteLine("Lumimyrsky.");
                Console.ReadKey();
            }
            else if (q1 == "K" && q2 == "K" && q3 == "E")
            {
                Console.WriteLine("Räntää.");
                Console.ReadKey();
            }
            else if (q1 == "K" && q2 == "E" && q3 == "E")
            {
                Console.WriteLine("Pakkasta.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Virhe. Käynnistä ohjelma uudelleen ja yritä jälleen. ");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
