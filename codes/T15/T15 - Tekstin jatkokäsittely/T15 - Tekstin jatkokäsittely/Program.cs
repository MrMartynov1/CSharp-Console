﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15___Tekstin_jatkokäsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna jokin sana: ");
            string value = Console.ReadLine();
            char[] array = value.ToCharArray();
            char[] cArray = value.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                Console.WriteLine(letter);
            }
            Console.ReadKey();

            Console.WriteLine(value);
            Console.ReadKey();

            string resultString = String.Join(" ", cArray);
            Console.Write(resultString);
            Console.ReadKey();
            Console.WriteLine();

            Array.Reverse(cArray);
            string resultRev = String.Join(" ", cArray);
            Console.Write(resultRev);
            Console.ReadKey();
            Console.Clear();
            if (value.IndexOf("A") != -1) {
            Console.WriteLine(value.IndexOf("A"));
            }
            else
            {
            Console.WriteLine("Virhe, ei ole Kirjainta 'A'.");
            }

            Console.ReadKey();
        }
    }
}
