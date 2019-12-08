using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6___For_silmukka
{
    class Program
    {
        static void Main(string[] args)
        {
            // sn = startnumber // variables: sn, num, i
            Console.Write("Valitse aloitusluku (1-10): ");
            string num = Console.ReadLine();
            Console.ReadKey();
            int sn;
            int.TryParse(num, out sn);
            int i;
            if (sn <=10)
            { 
            for (i=sn;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            }
            else
            {
                Console.WriteLine("Virhe. Pitää olla luku 1-10 välillä. Yritä uudelleen.");
            }
            Console.ReadKey();
            Console.Clear();
            // e = not to be confused with i
            for (int e=1; e<=100; e++)
            {
                if (e % 2 == 0)
                {
                    Console.Write(e + ", ");
                }

            }
            Console.ReadKey();
            Console.Clear();

            //x, y and z not be confused with previous variables
            Console.Write("Valitse aloitusluku (1-100): ");
            string x = Console.ReadLine();
            Console.ReadKey();
            int y;
            int.TryParse(x, out y);
            int z;
            if (y <= 100)
            {
                for (z = y; z >= 0; z--)
                {
                    Console.WriteLine(y);
                    y--;
                }
            }
            else
            {
                Console.WriteLine("Virhe. Pitää olla luku 1-100 välillä. Yritä uudelleen.");
            }
            Console.ReadKey();
            Console.Clear();

            //g, f and h to be not confused
            Console.Write("Valitse muuttuja (1-10): ");
            string h = Console.ReadLine();
            Console.ReadKey();
            int g;
            int.TryParse(h, out g);
            int f;
            if (g <= 10)
            {
                for (f=+1; f <=+10; f++)
                {
                    Console.WriteLine(+ g + " * " + f + " = " + g * f);
                }
                Console.ReadKey();
                for (f = +1; f <= +10; f++)
                {
                    Console.WriteLine(+ g + " / " + f + " = " + g / f);
                }
                Console.ReadKey();
                for (f = +1; f <= +10; f++)
                {
                    Console.WriteLine(+g + " % " + f + " = " + g % f);
                }
            }
            else
            {
                Console.WriteLine("Virhe. Pitää olla luku 1-10 välillä. Yritä uudelleen.");
            }
            Console.ReadKey();
            Console.Clear();

            //v, q, w and p to not be confused
            int v;
            Console.Write("Valitse luku: ");
            string q = Console.ReadLine();

            int.TryParse(q, out v);
            for (int p=1;p<v;p++)
            {
                for (int w = 1; w <= p; w++)
                {
                    Console.Write(w);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
