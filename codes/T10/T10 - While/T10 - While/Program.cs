using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10___While
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;

            while (luku < 10)

            {

                Console.WriteLine("Luku on " + luku);

                ++luku;

            }
            Console.ReadKey();
            Console.Clear();
            
            int sys;
            
            Console.WriteLine("Lisää summaan kunhan ei ole enemmän kuin 100: ");
          
            int sum = 0;

            while (sum <= 100)

            {
                sys = Int32.Parse(Console.ReadLine());

                sum = sys + sum;

                Console.WriteLine("Luku on " + sum);

                

            }
            if (sum > 100)

            {
                
                Console.WriteLine("Error, restart.");
                Console.ReadKey();
            }
            Console.ReadKey();
            Console.Clear();


            
            Console.Write("Arvaa numero: ");

            int arvaus = 0;

            
            while (arvaus < 45)

            {
                arvaus = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Luku on väärä.");
            }
            while (arvaus == 45)

            {
                arvaus = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Luku on oikein.");
                Console.ReadKey();
            }
            while (arvaus > 45)
            {
                arvaus = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Virhe.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
