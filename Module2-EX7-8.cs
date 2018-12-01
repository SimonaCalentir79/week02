using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema27nov18_ex7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------- INITIALIZARE SI POPULARE COLECTIE DE DATE INTRU REZOLVAREA EXERCITIILOR 7 si 8 -------------//
            Console.WriteLine("Introduceti un numar maxim (preferabil < 100) pana la care vor fi generate aleatoriu alte 20 numere necesare exercitiului.");
            int no2 = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int[] colectie1 = new int[20];//initializare colectie1 cu 20 pozitii
            int[] colectie2 = new int[20];//initializare colectie2 cu 20 pozitii

            Console.WriteLine("Numerele generate aleatoriu in intervalul 0 - " + no2.ToString() + " sunt:");

            while (i < 21)//pentru fiecare valoare a lui i mai mica decat 6...
            {
                int x = NrAleatorii(no2);//variabila x primeste o valoare aleatorie generata de functia NrAleatorii
                int y = NrAleatorii(no2);//variabila y primeste o valoare aleatorie generata de functia NrAleatorii

                colectie1[i - 1] = x;//colectia1 este populata la pozitia i-1 cu valoarea primita de x la linia de mai sus
                colectie2[i - 1] = y;//colectia2 este populata la pozitia i-1 cu valoarea primita de y la linia de mai sus

                Console.WriteLine("Numarul " + i.ToString() + " --> Colectia1 = " + x.ToString() + ", --> Colectia2 = " + y.ToString () + ".");//se afiseaza valoarile stocate in colectie
                i++;//se trece la urmatoarea valoare a lui i
            }
            Console.WriteLine("--------------------------------------------");
            //--------------------------------- IDENTIFICAREA ELEMENTELOR COMUNE INTRE CELE 2 COLECTII ------------------------------------//
            int j = 0;

            for (i = 0; i <= colectie1.Length - 1; i++)
            {
                for (j = 0; j <= colectie2.Length - 1; j++)
                {
                    if (colectie1[i] == colectie2[j])
                    {
                        Console.WriteLine("Elementul " + colectie1[i].ToString () + " se afla in ambele colectii si are in Colectia1 indexul " + i.ToString () + ", iar in Colectia2 indexul " + j.ToString () + ".");
                    }
                }
            }
            Console.WriteLine("--------------------------------------------");

            //--------------------------------- COPIEREA ELEMENTELOR DINTR-O COLECTIE, IN CEALALTA ------------------------------------//

            Console.WriteLine("Doriti inversarea elementelor intre cele doua colectii? y/n");
            string raspuns1 = Console.ReadLine();

            int[] colectie3 = new int[20];

            if (raspuns1 == "y")
            {
                i = 1;
                while (i < 21)
                {
                    colectie3[i - 1] = colectie1[i - 1];
                    colectie1[i - 1] = colectie2[i - 1];
                    colectie2[i - 1] = colectie3[i - 1];
                    Console.WriteLine("Numarul " + i.ToString() + " --> Colectia1 = " + colectie1[i-1].ToString() + ", --> Colectia2 = " + colectie2[i-1].ToString() + ".");
                    i++;
                }
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.WriteLine("Doriti copierea elementelor din Colectia2 in Colectia1? y/n");
                string raspuns2 = Console.ReadLine();
                if (raspuns2 == "y")
                {
                    for (i = 0; i <= colectie1.Length - 1; i++)
                    {
                        colectie1[i] = colectie2[i];
                        Console.WriteLine("Numarul " + i.ToString() + " --> Colectia1 = " + colectie1[i].ToString() + ", --> Colectia2 = " + colectie2[i].ToString() + ".");
                    }
                }
                if (raspuns2 == "n")
                {
                    Console.WriteLine("Ok. Atunci le copiem pe cele din Colectia1 in Colectia2! :) ");
                    Console.WriteLine("--------------------------------------------");
                    for (i = 0; i <= colectie2.Length - 1; i++)
                    {
                        colectie2[i] = colectie1[i];
                        Console.WriteLine("Numarul " + i.ToString() + " --> Colectia1 = " + colectie1[i].ToString() + ", --> Colectia2 = " + colectie2[i].ToString() + ".");
                    }
                }
                Console.WriteLine("--------------------------------------------");
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
