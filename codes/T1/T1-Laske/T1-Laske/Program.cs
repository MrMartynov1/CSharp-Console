using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Laske
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("1 * 5 = 5");
            Console.WriteLine("2 * 5 = 10");
            Console.WriteLine("3 * 5 = 15");
            Console.WriteLine("4 * 5 = 20");
            Console.WriteLine("5 * 5 = 25");
            Console.WriteLine("6 * 5 = 30");
            Console.WriteLine("7 * 5 = 35");
            Console.WriteLine("8 * 5 = 40");
            Console.WriteLine("9 * 5 = 45");
            Console.WriteLine("10 * 5 = 50");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("1*5= " + 1 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("2*5= " + 2 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("3*5= " + 3 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("4*5= " + 4 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("5*5= " + 5 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("6*5= " + 6 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("7*5= " + 7 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("8*5= " + 8 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("9*5= " + 9 * 5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("10*5= " + 10 * 5);
            Console.ReadKey();


            int num;
            Console.Write("Anna numero (1-10)");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vastaus" +num * 5);
            Console.ReadKey();
            
        }
    }
}
