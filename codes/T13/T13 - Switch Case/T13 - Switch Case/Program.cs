using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13___Switch_Case
{
    class Program
    {
        //public enum Pv { Maanantai = 1, Tiistai, Keskiviikko, Torstai, Perjantai, Lauantai, Sunnuntai }
        static void Main(string[] args)
        {
            ConsoleKeyInfo E;
            Console.WriteLine("Switch case demonstraatio: ");
            Console.ReadKey();
            Console.Write("Haluatko antaa viikonpäivän ensin (paina Y), vai haluatko antaa arvosanan (paina N)?");
            E = Console.ReadKey();
            
                if (E.Key == ConsoleKey.Y) { 
                int Vkpv;
                Console.Write("\n" + "Anna viikonpäivä numerona (1-7): ");
                Vkpv = Convert.ToInt32(Console.ReadLine());
                switch (Vkpv)
                {
                    case 1:
                        Console.WriteLine("Se on maanantai.");
                        break;
                    case 2:
                        Console.WriteLine("Se on tiistai.");
                        break;
                    case 3:
                        Console.WriteLine("Se on keskiviikko.");
                        break;
                    case 4:
                        Console.WriteLine("Se on torstai.");
                        break;
                    case 5:
                        Console.WriteLine("Se on perjantai.");
                        break;
                    case 6:
                        Console.WriteLine("Se on lauantai.");
                        break;
                    case 7:
                        Console.WriteLine("Se on sunnuntai.");
                        break;
                    default:
                        Console.WriteLine("Virhe. Anna luku joka on 7 tai alle (mutta ei 0).");
                        break;
                }
                Console.ReadKey();
            }
                
            
            bool te = true;
            Console.Clear();

            if (E.Key == ConsoleKey.N || te==true)
            {
                int Arv;
                Console.Write("Anna arvosana (1-10): ");
                Arv = Convert.ToInt32(Console.ReadLine());
                switch (Arv)
                {
                    case 1:
                        Console.WriteLine("Et edes yrittänyt.");
                        break;
                    case 2:
                        Console.WriteLine("Se on ULTRAHYLÄTTY.");
                        break;
                    case 3:
                        Console.WriteLine("Se on niin hylätty.");
                        break;
                    case 4:
                        Console.WriteLine("4 on hylätty.");
                        break;
                    case 5:
                        Console.WriteLine("5 on huono arvosana.");
                        break;
                    case 6:
                        Console.WriteLine("6 on välttävä arvosana.");
                        break;
                    case 7:
                        Console.WriteLine("7 on tyydyttävä arvosana.");
                        break;
                    case 8:
                        Console.WriteLine("8 on hyvä arvosana.");
                        break;
                    case 9:
                        Console.WriteLine("9 on kiitettävä arvosana.");
                        break;
                    case 10:
                        Console.WriteLine("10 on erinomainen arvosana.");
                        break;
                    default:
                        Console.WriteLine("Virhe. Anna luku joka on 7 tai alle (mutta ei 0).");
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
