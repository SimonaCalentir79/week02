using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------- INITIALIZARE SI POPULARE COLECTIE DE DATE INTRU REZOLVAREA HOMEWORK 2 -------------//
            Console.WriteLine("Introduceti un numar maxim (preferabil <= 10) pana la care vor fi generate aleatoriu alte 20 numere necesare exercitiului.");
            int no2 = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            List<int> stocNumere = new List<int>();

            Console.WriteLine("Numerele generate aleatoriu in intervalul 0 - " + no2.ToString() + " sunt:");
            while (i < 21)
            {
                int x = NrAleatorii(no2);
                stocNumere.Add(x);
                Console.WriteLine("Numarul " + i.ToString() + " este: " + x.ToString());
                i++;
            }
            Console.WriteLine("--------------------------------------------");

            foreach (var frcv in stocNumere.GroupBy(a => a))
            {
                Console.WriteLine("Numarul {0} are {1} aparitii.", frcv.Key , frcv.Count ());
            }

            Console.ReadLine();
        }
        public static Random _r = new Random();//variabila _r primeste o noua valoare random
        static int NrAleatorii(int no1)//functia NrAleatorii are rolul de a aloca lui y nr aleatoriu generat de Random
        {
            int y = _r.Next(no1);//variabila y primeste valoarea lui _r
            return y;//functia returneaza valoarea lui y
        }
    }
}
