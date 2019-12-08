using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T20___Alkuluvut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, k;
            k = 0;
            Console.Write("Lisää numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    k++;
                }
                if (k == 2)
                {
                    Console.WriteLine("On Alkunumero.");
                }
                else
                {
                    Console.WriteLine("Ei ole Alkunumero.");
                }
            }
            Console.WriteLine("Paina mitä tahansa näppäintä lopettaaksesi.");
            Console.ReadKey();
        }
    }
}
