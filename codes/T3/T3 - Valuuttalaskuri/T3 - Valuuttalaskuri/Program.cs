using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3___Valuuttalaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int eur;
            int s;
            var usd = 1.14;
            var pnd = 0.89;

            Console.WriteLine("Valuuttalaskuri");
            Console.ReadKey();
            Console.Write("Muunna eurot dollareiksi (paina 1) tai punniksi (paina 2) ");
            // eur = Convert.ToInt32(Console.ReadLine());
            string add = Console.ReadLine();
            int.TryParse(add, out s);

            if (s == 1)
            {
                Console.Write("Euro: ");
                eur = int.Parse(Console.ReadLine());

                Console.WriteLine("Dollareina: " + usd * eur);
                Console.ReadKey();
            }

            
            else if (s == 2)
            {
                Console.Write("Euro: ");
                eur = int.Parse(Console.ReadLine());

                Console.WriteLine("Puntina: " + pnd * eur);
                Console.ReadKey();
            }
            
            
            Console.ReadKey();
        }
    }
}
