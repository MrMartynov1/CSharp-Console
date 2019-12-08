﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliohjelmat_1
{
    class Program
    {
        private static void Tervehdys(string etunimi, string sukunimi, string ika)
        {
            Console.WriteLine("Tervetuloa ohjelmaan " + etunimi + " " + sukunimi + " !");
            Console.WriteLine("Ikäsi on " + ika + ".");
            int age;
            Console.Write("Jos olet mies paina m, jos olet nainen paina n: ");
            string gender = Console.ReadLine();

            if (gender == "m")
            {
                string num = ika;
                int.TryParse(num, out age);

                if (age < 13)
                {
                    Console.Write("Mitä poitsu?");
                    Console.ReadKey();
                }
                else if (age < 25)
                {
                    Console.Write("Mitä nuorimies?");
                    Console.ReadKey();
                }
                else if (age < 56)
                {
                    Console.Write("Olet mies parhaassa iässä.");
                    Console.ReadKey();
                }
                else if (age > 56)
                {
                    Console.Write("Olet vanhus.");
                    Console.ReadKey();
                }
            }
            else if (gender == "n")
            {
                Console.Write("Mikä on ikäsi? :");
                string num = Console.ReadLine();
                int.TryParse(num, out age);

                if (age < 13)
                {
                    Console.Write("Mitä tyttö?");
                    Console.ReadKey();
                }
                else if (age < 25)
                {
                    Console.Write("Mitä nuori nainen?");
                    Console.ReadKey();
                }
                else if (age < 56)
                {
                    Console.Write("Olet nainen parhaassa iässä.");
                    Console.ReadKey();
                }
                else if (age > 56)
                {
                    Console.Write("Olet mummeli.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Error, please restart and retry.");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Write("Nimesi: ");
            string etunimi = Console.ReadLine();

            Console.Write("Sukunimesi: ");
            string sukunimi = Console.ReadLine();

            Console.Write("Ikäsi: ");
            string ika = Console.ReadLine();

            Tervehdys(etunimi, sukunimi, ika);

            Console.ReadKey();
        }
    }
}
