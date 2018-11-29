using System;
namespace ConsoleApplication
{
    public class Tema02MinMax 
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the max number below which other 10 numbers will be generated, ");
            Console.WriteLine("in order to calculate the min and the max: ");
            string temp1 = Console.ReadLine();
            int no2 = Convert.ToInt32(temp1);

            int i = 1;
            int[] stocNumere = new int[10];//declarare array cu 10 pozitii
            Console.WriteLine("Numerele generate aleatoriu in intervalul 0 - " + no2.ToString() + " sunt: ");
            while (i < 11)//pentru fiecare val a lui i mai mica decat 11...
            {
                int x = NrAleatorii(no2);//variabila x primeste o valoare random generata de functia NrAleatorii
                stocNumere[i-1] = x;//populare array la poz i-1 cu valoarea x
                Console.WriteLine("Numarul " + i.ToString() + " este: " + x.ToString());
                i++;//trece la urmatoarea valoare a lui i
            }

            int min = stocNumere[0];//variabilei min i se aloca valoarea primei pozitii din array
            int max = stocNumere[0];//variabilei max i se aloca valoarea primei pozitii din array

            for (i = 1; i < stocNumere.Length; i++)
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
            Console.WriteLine("The highest number is: " + max.ToString());
            Console.WriteLine("The lowest number is: " + min.ToString());
            Console.WriteLine("-------------------------------------");
        }
        public static Random _r = new Random();//variabila _r preia un nou nr aleatoriu
        public static int NrAleatorii (int no1)//functia NrAleatorii cu argumentul no1
        {
            int x = _r.Next(no1);//aloca lui x o valoare aleatorie _r generata tinand cont de limita maxima no1
            return x;//returneaza x
        }
    }
}