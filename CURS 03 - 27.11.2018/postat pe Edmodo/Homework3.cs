using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------- INITIALIZARE SI POPULARE COLECTIE DE DATE INTRU REZOLVAREA HOMEWORK 3 -------------//
            Console.WriteLine("Introduceti un numar maxim pana la care vor fi generate aleatoriu alte 20 numere necesare exercitiului.");
            int no2 = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int[] colectie = new int[20];//initializare colectie1 cu 20 pozitii

            Console.WriteLine("Numerele generate aleatoriu in intervalul 0 - " + no2.ToString() + " sunt:");

            while (i < 21)//pentru fiecare valoare a lui i mai mica decat 6...
            {
                int x = NrAleatorii(no2);//variabila x primeste o valoare aleatorie generata de functia NrAleatorii

                colectie[i - 1] = x;//colectia1 este populata la pozitia i-1 cu valoarea primita de x la linia de mai sus

                Console.WriteLine("Numarul " + i.ToString() + " = " + x.ToString());//se afiseaza valoarile stocate in colectie
                i++;//se trece la urmatoarea valoare a lui i
            }
            Console.WriteLine("--------------------------------------------");

            List<int> ListaPare = new List<int>();
            List<int> ListaImpare = new List<int>();

            for (i = 0; i <= colectie.Length - 1; i++)
            {
                if (colectie [i] % 2 == 0)
                {
                    ListaPare.Add(colectie[i]);
                }
                else
                {
                    ListaImpare.Add(colectie[i]);
                }
            }

            Console.WriteLine("Colectia de numere pare cuprinde numerele: ");
            for (int x = 0; x < ListaPare.Count; x++)
                Console.Write(ListaPare[x] + " -- ");

            Console.WriteLine("   ");

            Console.WriteLine("Colectia de numere impare cuprinde numerele: ");
            for (int y = 0; y < ListaImpare.Count; y++)
                Console.Write(ListaImpare[y] + " -- ");

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
