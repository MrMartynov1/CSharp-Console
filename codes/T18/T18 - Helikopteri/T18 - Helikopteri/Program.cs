using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18___Helikopteri
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pw = 70;
            int Full = 400;

            Console.WriteLine("Matkatavarakapasiteetin laskija");
            Console.ReadKey();

            Console.Clear();

            Console.Write("Anna matkustajien määrä (Max. 4). (Paino: 70kg per hlö): ");

            char HLO = Console.ReadKey().KeyChar;

            switch (HLO)
            {
                case '1':
                    Console.Clear();
                    Console.Write("Anna matkustajien määrä (Max. 4). (Paino: 70kg per hlö): ");
                    Console.WriteLine("" + Pw * Convert.ToInt32(HLO.ToString()));
                    break;
                case '2':
                    Console.Clear();
                    Console.Write("Anna matkustajien määrä (Max. 4). (Paino: 70kg per hlö): ");
                    Console.WriteLine(Pw * Convert.ToInt32(HLO.ToString()));
                    break;
                case '3':
                    Console.Clear();
                    Console.Write("Anna matkustajien määrä (Max. 4). (Paino: 70kg per hlö): ");
                    Console.WriteLine(Pw * Convert.ToInt32(HLO.ToString()));
                    break;
                case '4':
                    Console.Clear();
                    Console.Write("Anna matkustajien määrä (Max. 4). (Paino: 70kg per hlö): ");
                    Console.WriteLine(Pw * Convert.ToInt32(HLO.ToString()));
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Virhe, anna numero 1-4 välillä. Käynnistä uudelleen.");
                    Console.ReadKey();
                    return;
            }
            Console.ReadKey();
            Console.Clear();
            int Final1 = Pw * Convert.ToInt32(HLO.ToString());



            int Subfull = CheckWeight(Final1);


            Console.Clear();
            Console.WriteLine("Lopullinen paino: " + Subfull);
            Console.ReadKey();
            Console.WriteLine("Vapaana on: " + (Full - Subfull));
            
            Console.ReadKey();

        }
    
        static int CheckWeight(int Final1)
        {
            int Final2;
            if (Final1 < 380)
            {

                while (Final1 < 380)
                {
                    Console.WriteLine("Matkatavaratilaa jäljellä: " + (380 - Final1));
                    Console.Write("Lisää: ");
                    if (int.TryParse(Console.ReadLine(), out Final2))
                    {

                        if (Final1 + Final2 <= 380)
                        {
                            Final1 += Final2;
                        }
                        else
                        {
                            Console.Write("Liikaa painoa. Haluatko jatkaa? (Y/N)  ");
                            string Answer = Console.ReadLine();
                            if (Answer == "Y")
                            {
                                Console.WriteLine("Jatkuu.");
                            }
                            else if(Answer == "N")
                            {
                                return Final1;
                            }
                            else
                            {
                                Console.WriteLine("Ei Y eikä N. Jatkuu.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ei ole numero. Haluatko jatkaa? Y/N  ");
                        string Answer = Console.ReadLine();
                        if (Answer == "Y")
                        {
                            Console.WriteLine("Jatkuu.");
                        }
                        else if (Answer == "N")
                        {
                            return Final1;
                        }
                        else
                        {
                            Console.WriteLine("Ei Y eikä N. Jatkuu.");
                        }
                    }
                    Console.WriteLine("Paino on " + Final1);

                }

            }
            else
            {
                Console.WriteLine("Virhe.");
                Console.ReadKey();
            }
            return 380;
        }
    }
}
