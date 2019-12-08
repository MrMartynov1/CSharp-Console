using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T0_Tulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hei Maailma!");
            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.Write("Kerro Nimesi: ");
            string Nimi = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.Write("Kerro Sukunimesi: ");
            string Sukunimi = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.Write("Terve, Toveri " +Nimi+ " " +Sukunimi+"!");
            Console.ReadKey();
        }
    }
}
