using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema27nov18_ex1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //------------- INITIALIZARE SI POPULARE COLECTIE DE DATE INTRU REZOLVAREA EXERCITIILOR -------------//
            Console.WriteLine("Introduceti un numar maxim pana la care vor fi generate aleatoriu alte 5 numere necesare exercitiului.");
            int no2 = Convert.ToInt32(Console.ReadLine ());

            int i = 1;
            int[] stocNumere = new int[5];//initializare colectie cu 5 pozitii
            Console.WriteLine("Numerele generate aleatoriu in intervalul 0 - " + no2.ToString() + " sunt:");
            while (i < 6)//pentru fiecare valoare a lui i mai mica decat 6...
            {
                int x = NrAleatorii(no2);//variabila x primeste o valoare aleatorie generata de functia NrAleatorii
                stocNumere[i - 1] = x;//colectia stocNumere este populata la pozitia i-1 cu valoarea primita de x la linia de mai sus
                Console.WriteLine("Numarul " + i.ToString() + " este: " + x.ToString());//se afiseaza valoarea stocata in colectie
                i++;//se trece la urmatoarea valoare a lui i
            }
            Console.WriteLine("--------------------------------------------");

            //------------- SUMA ELEMENTELOR STOCATE IN COLECTIA DE DATE -------------//
            double suma = 0.0;
            for (int a = 0; a < stocNumere.Length; a++ )
            {
                suma = suma + stocNumere[a];
            }
            Console.WriteLine("Suma numerelor este:" + suma.ToString ());
            Console.WriteLine("--------------------------------------------");

            //------------- MEDIA ARITMETICA A ELEMENTELOR DIN COLECTIE -------------//
            double  medar = suma / stocNumere.Length;
            Console.WriteLine("Media aritmetica a numerelor este:" + medar.ToString());
            Console.WriteLine("--------------------------------------------");

            //------------- IDENTIFICAREA INDEXULUI UNUI ELEMENT DIN COLECTIE -------------//
            Console.WriteLine("Alegeti unul din numerele colectiei afisate mai sus, in vederea identificarii indexului acestuia!!");
            int no3 = Convert.ToInt32(Console.ReadLine());
            int valel = 0;
            for (i = 0; i <= stocNumere.Length - 1; i++)
            {
                valel = stocNumere[i];
                if (no3 == valel)
                {
                    Console.WriteLine("Numarul " +no3.ToString ()+ " are indexul " + i.ToString() + " in cadrul colectiei date.");
                    Console.WriteLine("--------------------------------------------");
                }
            }//de tratat situatia in care nu se alege un nr din colectie

            //------------- ELIMINAREA UNUI ELEMENT DIN COLECTIE -------------//
            Console.WriteLine("Selectati unul din elementele colectiei in vederea eliminarii lui!");
            int no4 = Convert.ToInt32(Console.ReadLine ());
            int valel2 = 0;
            Console.WriteLine("Colectia are acum urmatoarele elemente:");
            for (i = 0; i <= stocNumere.Length - 1; i++)
            {
                valel2 = stocNumere[i];
                if (no4 == valel2)
                {
                    stocNumere[i] = 0;
                    valel2 = stocNumere[i];
                }
                Console.WriteLine("La indexul " + i.ToString() + " se afla numarul " + stocNumere[i].ToString() + ". ");
            }//de tratat situatia in care nu se alege un nr din colectie

            //------------- INSERAREA UNUI ELEMENT IN COLECTIE, PE O ANUMITA POZITIE -------------//
            Console.WriteLine("Specificati, in cadrul colectiei, indexul elementului pe care doriti sa-l modificati!");
            int no5 = Convert.ToInt32(Console.ReadLine ());

            Console.WriteLine("Acum specificati valoarea pe care doriti sa o alocati acestui element!");
            int no6 = Convert.ToInt32(Console.ReadLine ());

            stocNumere[no5] = no6;

            Console.WriteLine("Colectia are acum urmatoarele elemente:");
            for (i = 0; i <= stocNumere.Length - 1; i++)
            {
                Console.WriteLine("La indexul " + i.ToString () + " se afla numarul " + stocNumere[i].ToString () + ".");
            }

            //------------- AFLAREA VALORII MAXIME SI MINIME IN CADRUL UNEI COLECTII -------------//
            Console.WriteLine("Doriti aflarea valorilor maxime si minime din cadrul acestei colectii? y/n");
            string raspuns = Console.ReadLine();
            if (raspuns == "y")
            {

                int min = stocNumere[0];//variabilei min i se aloca valoarea primei pozitii din array
                int max = stocNumere[0];//variabilei max i se aloca valoarea primei pozitii din array

                for (i = 0; i < stocNumere.Length; i++)
                {
                    if (min > stocNumere[i])
                    {
                        min = stocNumere[i];
                    }
                    if (max < stocNumere[i])
                    {
                        max = stocNumere[i];
                    }
                }
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Cel mai mare numar din colectie este: " + max.ToString());
                Console.WriteLine("Cel mai mic numar din colectie este: " + min.ToString());
                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("OK. La revedere!!");
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
