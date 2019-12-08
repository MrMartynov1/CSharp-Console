using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8___Vakioluettelo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    namespace EnumTh
    {
        class Program
        {
            public enum Vuodenaika { kevat = 1, kesa = 2, syksy = 3, talvi = 0 }
            public enum Month { Jan =1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }

            static void Main(string[] args)
            {
                Console.WriteLine((int)Vuodenaika.syksy);
                Console.ReadKey();
                Console.Clear();

                int sijoitus = 1;
                Console.Write("Anna kuukausi numerona (1-12): ");
                sijoitus = int.Parse(Console.ReadLine());
                Console.WriteLine((Month)sijoitus);
                if (sijoitus <12)
                {
                    Console.WriteLine((Vuodenaika)Math.Ceiling(new decimal(sijoitus / 3)));
                }
                else if (sijoitus == 12)
                {
                    Console.WriteLine((Vuodenaika)0);
                }
                else
                {
                    Console.WriteLine("Virhe. Käynnistä ja yritä uudelleen.");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Mikä vuodenaika on?");

                Console.WriteLine(DateTime.Now.Month.ToString());
                Console.ReadKey();
            }

        }
    }
}
