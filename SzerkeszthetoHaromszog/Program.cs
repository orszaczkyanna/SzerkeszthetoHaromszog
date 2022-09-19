using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerkeszthetoHaromszog
{
    class Program
    //Bekéri egy háromszög oldalainak a hosszát és kiírja, hogy szerkeszthető-e. 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a háromszög három oldalának hosszát!");
            int haromSzogOldalA = PozitivEgeszSzam("a: ");
            int haromSzogOldalB = PozitivEgeszSzam("b: ");
            int haromSzogOldalC = PozitivEgeszSzam("c: ");
            Console.WriteLine($"A háromszög {SzerkeszthetoE(haromSzogOldalA, haromSzogOldalB, haromSzogOldalC)}");
            Console.ReadKey();

        }

        private static string SzerkeszthetoE(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return "szerkeszthető";
            }
            else
            {
                return "nem szerkeszthető";
            }

        }

        private static int PozitivEgeszSzam(string kiIrandoSzoveg)
        {
            int visszateresiErtek;
            int leptet = 0;
            Console.Write(kiIrandoSzoveg);

            do
            {
                if (leptet > 0)
                {
                    Console.Write("Hibás érték! Adj meg másikat: ");
                }
                leptet++;

            } while (!int.TryParse(Console.ReadLine(), out visszateresiErtek) || visszateresiErtek <= 0);

            return visszateresiErtek;
        }


    }
}
