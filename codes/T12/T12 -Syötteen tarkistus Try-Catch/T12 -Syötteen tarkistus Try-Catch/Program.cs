using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12__Syötteen_tarkistus_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            num = new int[5];
            Console.WriteLine("Anna 5 kokonaislukua: ");
            num[0] = Int32.Parse(Console.ReadLine());
            num[1] = Int32.Parse(Console.ReadLine());
            num[2] = Int32.Parse(Console.ReadLine());
            num[3] = Int32.Parse(Console.ReadLine());
            num[4] = Int32.Parse(Console.ReadLine());
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
