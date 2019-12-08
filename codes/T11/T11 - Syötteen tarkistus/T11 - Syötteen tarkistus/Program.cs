using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11___Syötteen_tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            num = new int[5];
            int test;
            Console.WriteLine("Anna 5 kokonaislukua: ");

            for (int i = 0; i < 5; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out test))
                {
                    Console.WriteLine("error: input not numbers");
                    continue;
                }
                num[i] = test;
            }

            
            int sum = 0;
                foreach (int x in num)
                {
                sum += x;
                }
            

            int aver = sum / num.Length;
            Console.WriteLine("average: {0}", aver);

            Console.ReadKey();
        }
    }
}
