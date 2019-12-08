using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2___Pituusmuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            int cm;

            Console.Write("Enter your height in centimeters: ");
            cm = Convert.ToInt32(Console.ReadLine());
            //
            var meter = 0.01;
            var inch = 0.39;
            var mile = 0.00;
            var yard = 0.01;
            Console.WriteLine("In meters: " + meter * cm);
            Console.WriteLine("In inches: " + inch * cm);
            Console.WriteLine("In yards: " + yard * cm);
            Console.WriteLine("In miles: " + mile * cm);
            Console.ReadKey();
        }
    }
}
