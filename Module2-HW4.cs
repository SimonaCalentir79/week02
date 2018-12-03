using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    public class Functii
    {
        public static void MeniuPrincipal()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("   Returning to 'Main menu'? y/n");
            string raspuns = Console.ReadLine();
            if (raspuns == "y")
                Program.Main();
            if (raspuns == "n")
                Console.WriteLine("   OK.");
            Console.WriteLine("--------------------------------------");
        }
        public static void Afisare(LinkedList<string> cuvinte, string detalii)
        {
            Console.WriteLine(detalii);
            foreach (string cuvint in cuvinte)
                Console.Write("   " + cuvint + " ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
        public static void Afisare2(List<int> valori, string detalii)
        {
            Console.WriteLine(detalii);
            foreach (int valoare in valori)
                Console.Write(" {0} ", valoare);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
        }
        public static void AfisareArr(string[] arr, string detalii)
        {
            Console.WriteLine(detalii);
            for (int i = 0; i <= arr.Length -1; i++)
                Console.Write(" {0} ",arr[i].ToString ());
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
        public static Random _r = new Random();//variabila _r primeste o noua valoare random
        public static int NrAleatorii(int no1)//functia NrAleatorii are rolul de a aloca lui y o valoare aleatorie generata de Random
        {
            int y = _r.Next(no1);//variabila y primeste valoarea lui _r
            return y;//functia returneaza valoarea lui y
        }
        public static int[] GenIntArray2(int no6)
        {
            int i = 1;
            int[] array2 = new int[no6];
            //Console.WriteLine("-----");
            while (i <= no6)
            {
                array2[i - 1] = i;
                //Console.WriteLine("pos. {0} -- val. {1}",i.ToString(),array2[i-1].ToString());
                i++;
            }
            return array2;
        }
        public static int[] GenIntArray(int no1, int no2)//functia GenIntArray are rolul de a genera un 'array' de tip integer cu lungimea si val. maxima a elementelor specificate de utilizator
        {
            int i = 1;
            int[] array1 = new int[no1];
            Console.WriteLine("...contains the following elements:");
            while (i <= no1)
            {
                int x = NrAleatorii(no2);
                array1[i - 1] = x;
                Console.WriteLine("   On pos. " + i.ToString() + " is value " + x.ToString());
                i++;
            }
            return array1;
        }
        public static string[] GenStrArray(string caractere)//functia GenStrArray are rolul de a genera un 'array' de tip string cu lungimea specificata de utilizator
        {
            if (caractere.Length == 0)
            {
                Console.WriteLine("   You didn't enter anything!");
            }

            string[] arrCaractere = new string[caractere.Length];
            for (int x = 0; x <= caractere.Length - 1; x++)
            {
                arrCaractere[x] = caractere[x].ToString();
                //Console.Write(" {0} ",arrCaractere[x].ToString());
            }
            return arrCaractere;
        }
    }
    public class Rezolvare
    {
        public static void Exercitiul1()
        {
            Console.WriteLine("   We need to create two arrays of integers.");

            Console.WriteLine("   How many elements do you want these arrays to contain?");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("   The code will randomly generate the elements of these two arrays. Please enter the maximum value an element can take!");
            int no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("   'Array' no.1 ... ");
            int[] ArrayI = new int[no1];
            Functii.GenIntArray(no1, no2).CopyTo(ArrayI, 0);

            Console.WriteLine(" ");

            Console.WriteLine("   'Array' no.2 ... ");
            int[] ArrayII = new int[no1];
            Functii.GenIntArray(no1, no2).CopyTo(ArrayII, 0);

            for (int i = 0; i <= ArrayI.Length - 1; i++)
            {
                for (int j = 0; j <= ArrayII.Length - 1; j++)
                {
                    if (ArrayI[i] == ArrayII[j])
                        Console.WriteLine("   Value " + ArrayI[i].ToString() + " exists in Array no.1 on index " + i.ToString() + " and in Array no.2 on index " + j.ToString());                
                }
            }
            Functii.MeniuPrincipal();
        }
        public static void Exercitiul2()
        {
            Console.WriteLine("   Enter a few repetitive letters/words!");
            string sirCaractere = Console.ReadLine();

            string[] arrCaractere = new string[sirCaractere.Length];
            Functii.GenStrArray(sirCaractere).CopyTo(arrCaractere,0);

            List<string> duplicate = new List<string>();
            for (int y = 0; y <= arrCaractere.Length - 1; y++)
            {
                int counter = 0;
                if (duplicate.Contains(arrCaractere[y]))
                {
                    continue;
                }
                duplicate.Add(arrCaractere[y]);
                for (int z = 0; z < arrCaractere.Length; z++)
                {
                    if (arrCaractere[y] == arrCaractere[z])
                        counter++;
                }
                if (counter != 1)
                    Console.WriteLine("   Character '{0}' appears {1} times.", arrCaractere[y], counter);
                if (counter == 1)
                    Console.WriteLine("   Character '{0}' is unique in this string!",arrCaractere[y]);
            }
            Functii.MeniuPrincipal();
        }
        public static void Exercitiul3()
        {
            Console.WriteLine("   Enter a few repetitive letters/words!");
            string enunt = Console.ReadLine();

            string[] arrCuvinte = new string[enunt.Length];
            Functii.GenStrArray(enunt).CopyTo(arrCuvinte,0);

            LinkedList<string> listaCrct = new LinkedList<string>();

            for (int x = 0; x <= arrCuvinte.Length - 1; x++)
            {
                int counter = 0;
                if (listaCrct.Contains(arrCuvinte[x].ToString()))
                    continue;
                listaCrct.AddLast(arrCuvinte[x]);
                for (int y = 0; y <= arrCuvinte.Length - 1; y++)
                {
                    if (arrCuvinte[x] == arrCuvinte[y])
                        counter++;
                }
                if (counter != 1)
                    listaCrct.Remove(arrCuvinte[x]);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Functii.Afisare(listaCrct, "   Without the duplicates, the list contains the following:");
            Functii.MeniuPrincipal();
        }
        public static void Exercitiul4()
        {
            Console.WriteLine("   Enter the number to check!");
            Console.WriteLine("   (Please, choose a number < 10.000 if you want the result today :) )");
            int numar = Convert.ToInt32(Console.ReadLine());

            int[] arrNumere = new int[numar];
            Functii.GenIntArray2(numar).CopyTo(arrNumere,0);

            List<int> lstDivizibile = new List<int>();
            List<int> lstPrime = new List<int>();

            for (int x = 0; x <= arrNumere.Length - 1; x++)
            {
                for (int y = 0; y <= arrNumere.Length - 1; y++)
                {
                    if (arrNumere[x] % arrNumere[y] == 0 && arrNumere[y] != 1 && arrNumere[x] != arrNumere[y])
                        lstDivizibile.Add(arrNumere[x]);
                }
            }
            for (int x = 0; x <= arrNumere.Length - 1; x++)
            {
                for (int y = 0; y <= lstDivizibile.Count - 1; y++)
                {
                    if (arrNumere[x] == lstDivizibile[y])
                        arrNumere[x] = 0;
                }
            }
            for (int x = 0; x <= arrNumere.Length - 1; x++)
            {
                if (arrNumere[x] != 0)
                    lstPrime.Add(arrNumere[x]);
            }
            int counter = 0;
            for (int x = 0; x <= lstPrime.Count - 1; x++)
            {
                if (numar % lstPrime[x] == 0 && lstPrime[x] != 1 && numar != lstPrime[x])
                {
                    counter++;
                    Console.WriteLine("   Number {0} isn't prime because it's divisible by {1}.", numar.ToString(), lstPrime[x].ToString());
                }
            }
            if (counter == 0)
                Console.WriteLine("   Number {0} is prime!",numar.ToString());

            //Functii.Afisare2(lstNrPrime, "Numerele prime <= " + numar.ToString() + " sunt: ");
            Functii.MeniuPrincipal();
        }
        public static void Exercitiul5()
        {
            Console.WriteLine("   Enter the word to check!");
            string cuvant = Console.ReadLine();

            string[] arrCuvant = new string[cuvant.Length];
            string[] arrPeDos = new string[cuvant.Length];
            Functii.GenStrArray(cuvant).CopyTo(arrCuvant,0);
            Functii.GenStrArray(cuvant).CopyTo(arrPeDos,0);

            Array.Reverse(arrPeDos);

            Functii.AfisareArr(arrCuvant, "   Before reverse:");
            Console.WriteLine("--------------------------------");
            Functii.AfisareArr(arrPeDos, "   After reverse:");
            Console.WriteLine("--------------------------------");

            int counter = 0;
            for (int a = 0; a <= arrCuvant.Length - 1; a++)
            {
                if (arrCuvant[a] == arrPeDos[a])
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }
            if (arrCuvant.Length == counter)
            {
                Console.WriteLine("   The word you chose is a palindrome!");
            }
            else
            {
                Console.WriteLine("   Nope! Not a palindrome!");
            }
            Functii.MeniuPrincipal();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("       Enter the number of the exercise you want to test! (1,2,3,4 or 5)");
            Console.WriteLine("               Ex.1: Find common elements between two arrays of integers.");
            Console.WriteLine("               Ex.2: Implement an algorithm to determine if a string has all unique characters.");
            Console.WriteLine("               Ex.3: Write code to remove duplicates from an unsorted linked list.");
            Console.WriteLine("               Ex.4: Write a function to check if a number is prime or not.");
            Console.WriteLine("               Ex.5: Check if a word is a palindrome.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            int raspuns = Convert.ToInt32(Console.ReadLine());

            if (raspuns == 1)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 1: Find common elements between two arrays of integers.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul1();
                Console.WriteLine(" ");
            }
            else if (raspuns == 2)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 2: Implement an algorithm to determine if a string has all unique characters.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul2();
                Console.WriteLine(" ");
            }
            else if (raspuns == 3)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 3: Write code to remove duplicates from an unsorted linked list.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul3();
                Console.WriteLine(" ");
            }
            else if (raspuns == 4)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 4: Write a function to check if a number is prime or not.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul4();
                Console.WriteLine(" ");
            }
            else if (raspuns == 5)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 5: Check if a word is a palindrome.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul5();
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("   Finish!!!");
            }
            Console.ReadLine();
        }
    }
}
