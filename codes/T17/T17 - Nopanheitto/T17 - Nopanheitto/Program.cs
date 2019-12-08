using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17___Nopanheitto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, summa=0, result;
            Random Dice = new Random();
            Console.WriteLine("Nopanheitto");
            Console.ReadKey();
            Console.WriteLine("Kahta noppaa tullaan heittämään 5 kertaa. Paina mitä tahansa näppäintä.");
            Console.ReadKey();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                num1 = Dice.Next(1, 7);
                num2 = Dice.Next(1, 7);
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine();
                result = num1 + num2;
                Console.WriteLine("Tämän kierroksen heittojen summa on: " + result);
                Console.WriteLine("-");
                summa = summa + result;
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Kaikkien heittojen summa on: " + summa);

            Console.ReadKey();

        }
    }
}
