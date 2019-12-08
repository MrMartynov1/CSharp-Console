using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7___Taulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] fruit = new int[3];

            fruit[0] = 1;
            fruit[1] = 1;
            fruit[2] = 1;

            Console.WriteLine(fruit[1]);

            Console.ReadKey();
            Console.Clear();


            Console.Write("Montako hedelmää haluat nähdä? ");
            string ammount = Console.ReadLine();

            if (ammount == "1")
            {

                Console.WriteLine(fruit[0]);
                Console.ReadKey();
            }
            else if (ammount == "2")
            {
                Console.WriteLine(fruit[0]);
                Console.WriteLine(fruit[1]);
                Console.ReadKey();
            }
            else if (ammount == "3")
            {
                Console.WriteLine(fruit[0]);
                Console.WriteLine(fruit[1]);
                Console.WriteLine(fruit[2]);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Virhe, on vain 3 hedelmää, käynnistä uudelleen.");
                Console.ReadKey();
            }
            Console.Clear();
            string[] arrayfruit = {"Omena","Ananas","Banaani","Appelsiini","Mandariini","Mango","Vesimeloni"};
            int[] price = { 1, 5, 2, 3, 1, 4, 10 };
            string[] currency = { "€" };
            
            Console.WriteLine(arrayfruit[0] + ", " + price[0] + currency[0]);
            Console.WriteLine(arrayfruit[1] + ", " + price[1] + currency[0]);
            Console.WriteLine(arrayfruit[2] + ", " + price[2] + currency[0]);
            Console.WriteLine(arrayfruit[3] + ", " + price[3] + currency[0]);
            Console.WriteLine(arrayfruit[4] + ", " + price[4] + currency[0]);
            Console.WriteLine(arrayfruit[5] + ", " + price[5] + currency[0]);
            Console.WriteLine(arrayfruit[6] + ", " + price[6] + currency[0]);

            Console.ReadKey();
            Console.Clear();

            

            int[] tuotelkm = { 0, 0, 0, 0, 0, 0, 0 };
            decimal[] tuotehinta = {1.10m, 4.70m, 2.40m, 3.00m, 1.00m, 5.10m, 10.45m};
            string[] tuotenimi = { "Omena", "Ananas", "Banaani", "Appelsiini", "Mandariini", "Mango", "Vesimeloni" };

            Console.WriteLine("Valitse tuote (1-7): ");
            int tuote = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valitse tuotteiden lukumäärä (1-7): ");
            tuotelkm[tuote-1] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 3; i++) {
                if(tuotelkm[i] > 0)
                {
                    Console.WriteLine(tuotenimi[i] + ", " + tuotelkm[i] * tuotehinta[i] + currency[0]);
                }

            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Kuinka monta tuotetta lisätään? ");
            int tuotemäärä = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tuotemäärä; i++) {
                
                Console.WriteLine("Anna tuotteen " + (i + 1) + " nimi: ");
                tuotenimi[i] = Console.ReadLine();
                Console.WriteLine("Anna tuotteen " + (i + 1) + " hinta: ");
                tuotehinta[i] = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Anna tuotteen " + (i + 1) + " lukumäärä: ");
                tuotelkm[i] = Convert.ToInt32(Console.ReadLine());
              

            }
            for (int i = 0; i < tuotemäärä; i++)
            {
                
                    Console.WriteLine(tuotenimi[i] + ", " + tuotelkm[i] * tuotehinta[i] + currency[0]);
                


            }
            Console.ReadKey();
            Console.Clear();


        }
    }
}
