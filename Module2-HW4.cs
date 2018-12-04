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
            int no1 = Convert.ToInt32(Console.ReadLine());//preluare valoare utilizator in var. no1

            Console.WriteLine("   The code will randomly generate the elements of these two arrays. Please enter the maximum value an element can take!");
            int no2 = Convert.ToInt32(Console.ReadLine());//preluare valoare utilizator in var. no2

            Console.WriteLine("   'Array' no.1 ... ");
            int[] ArrayI = new int[no1];//primul array creat prin
            Functii.GenIntArray(no1, no2).CopyTo(ArrayI, 0);//apelarea metodei 'GenIntArray' din clasa 'Functii'

            Console.WriteLine(" ");

            Console.WriteLine("   'Array' no.2 ... ");
            int[] ArrayII = new int[no1];//al 2-lea array creat prin
            Functii.GenIntArray(no1, no2).CopyTo(ArrayII, 0);//apelarea metodei 'GenIntArray' din clasa 'Functii'

            for (int i = 0; i <= ArrayI.Length - 1; i++)//fiecare valoare de la idx i din ArrayI
            {
                for (int j = 0; j <= ArrayII.Length - 1; j++)//este comparata cu fiecare valoare de la idx j din ArrayII
                {
                    if (ArrayI[i] == ArrayII[j])//daca valorile sunt egale...
                        Console.WriteLine("   Value " + ArrayI[i].ToString() + " exists in Array no.1 on index " + i.ToString() + " and in Array no.2 on index " + j.ToString());                
                }
            }
            Functii.MeniuPrincipal();//apeleaza functia 'MeniuPrincipal' din clasa Functii
        }
        public static void Exercitiul2()
        {
            Console.WriteLine("   Enter a few repetitive letters/words!");
            string sirCaractere = Console.ReadLine();//preluare valoare utilizator in var. sirCaractere

            string[] arrCaractere = new string[sirCaractere.Length];//array-ul arrCaractere creat prin
            Functii.GenStrArray(sirCaractere).CopyTo(arrCaractere,0);//apelarea functiei 'GenStrArray' din clasa 'Functii'

            List<string> duplicate = new List<string>();//lista creata pt a evita numararea de mai multe ori a unui acelasi element
            for (int y = 0; y <= arrCaractere.Length - 1; y++)
            {
                int counter = 0;                        //declarare counter
                if (duplicate.Contains(arrCaractere[y]))//daca lista contine elementul de la idx y
                {
                    continue;                           //sa continue
                }
                duplicate.Add(arrCaractere[y]);         //adauga elementul in lista
                for (int z = 0; z < arrCaractere.Length; z++)//fiecare din elem. arr. cu idx y este comparat cu cele de la idx z
                {
                    if (arrCaractere[y] == arrCaractere[z])  //daca au aceleasi valori
                        counter++;                           //se incrementeaza counter
                }
                if (counter != 1)//daca egalitatea de mai sus s-a intalnit cel putin o data, valoarea counter este > 1
                    Console.WriteLine("   Character '{0}' appears {1} times.", arrCaractere[y], counter);
                if (counter == 1)//daca egalitatea de mai sus s-a intalnit doar o data, elementul este unic
                    Console.WriteLine("   Character '{0}' is unique in this string!",arrCaractere[y]);
            }
            Functii.MeniuPrincipal();//se apeleaza metoda 'Meniu Principal' din clasa 'Functii'
        }
        public static void Exercitiul3()
        {
            Console.WriteLine("   Enter a few repetitive letters/words!");
            string enunt = Console.ReadLine();//preluare valoare utilizator in var. sirCaractere

            string[] arrCuvinte = new string[enunt.Length];//array-ul arrCuvinte creat prin
            Functii.GenStrArray(enunt).CopyTo(arrCuvinte,0);//apelarea functiei 'GenStrArray' din clasa 'Functii'

            LinkedList<string> listaCrct = new LinkedList<string>();//lista creata pt a evita numararea de mai multe ori a unui acelasi element

            for (int x = 0; x <= arrCuvinte.Length - 1; x++)
            {
                int counter = 0;                                    //declarare variabila counter
                if (listaCrct.Contains(arrCuvinte[x].ToString()))   //daca lstCrct contine elem. de la idx x
                    continue;                                       //sa treaca la urm.elem.
                listaCrct.AddLast(arrCuvinte[x]);                   //adauga elem. in lista
                for (int y = 0; y <= arrCuvinte.Length - 1; y++)    //elem. de la idx x se compara cu fiecare elem. de la idx y
                {
                    if (arrCuvinte[x] == arrCuvinte[y])             //daca au aceeasi valoare
                        counter++;                                  //se incrementeaza counter-ul
                }
                if (counter != 1)                                   //daca val counter <> 1, adica elem a fost gasit de mai mult de 1 data
                    listaCrct.Remove(arrCuvinte[x]);                //se comanda stergerea lui din lista
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Functii.Afisare(listaCrct, "   Without the duplicates, the list contains the following:");
            Functii.MeniuPrincipal();//apeleaza functia 'MeniuPrincipal' din clasa Functii
        }
        public static void Exercitiul4()
        {   //pentru a afla daca un nr este prim, acestuia ii trebuie verificata divizibilitatea cu toate nr prime mai mici decat el
            Console.WriteLine("   Enter the number to check!");
            Console.WriteLine("   (Please, choose a number < 10.000 if you want the result today :) )");
            int numar = Convert.ToInt32(Console.ReadLine());//preluare valoare utilizator in var. numar

            int[] arrNumere = new int[numar];//array-ul arrNumere creat prin
            Functii.GenIntArray2(numar).CopyTo(arrNumere,0);//apelarea functiei 'GenIntArray2' din clasa 'Functii'

            List<int> lstDivizibile = new List<int>();//initializare lista lstDivizibile
            List<int> lstPrime = new List<int>();//initializare lista lstPrime
            
            for (int x = 0; x <= arrNumere.Length - 1; x++)//se creeaza o lista a divizibililor in vederea aflarii nr prime < nr verificat
            {
                for (int y = 0; y <= arrNumere.Length - 1; y++)
                {
                    if (arrNumere[x] % arrNumere[y] == 0 && arrNumere[y] != 1 && arrNumere[x] != arrNumere[y])
                        lstDivizibile.Add(arrNumere[x]);
                }
            }
            for (int x = 0; x <= arrNumere.Length - 1; x++)//se inloc val divizibililor din array, cu val. 0
            {
                for (int y = 0; y <= lstDivizibile.Count - 1; y++)
                {
                    if (arrNumere[x] == lstDivizibile[y])
                        arrNumere[x] = 0;
                }
            }
            for (int x = 0; x <= arrNumere.Length - 1; x++)//se creeaza lista nr prime
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
            Functii.MeniuPrincipal();//apeleaza functia 'MeniuPrincipal' din clasa Functii
        }
        public static void Exercitiul5()
        {
            Console.WriteLine("   Enter the word to check!");
            string cuvant = Console.ReadLine();//preluare valoare utilizator in var. cuvant

            string[] arrCuvant = new string[cuvant.Length];//array-ul arrCuvant creat prin
            Functii.GenStrArray(cuvant).CopyTo(arrCuvant, 0);//apelarea functiei 'GenStrArray' din clasa 'Functii'

            string[] arrPeDos = new string[cuvant.Length];//array-ul arrPeDos creat prin
            Functii.GenStrArray(cuvant).CopyTo(arrPeDos,0);//apelarea functiei 'GenStrArray' din clasa 'Functii'

            Array.Reverse(arrPeDos);//inversare elemente din arrPeDos

            Functii.AfisareArr(arrCuvant, "   Before reverse:");//apelarea functiei 'AfisareArr' din clasa 'Functii'
            Console.WriteLine("--------------------------------");
            Functii.AfisareArr(arrPeDos, "   After reverse:");//apelarea functiei 'AfisareArr' din clasa 'Functii'
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
                Rezolvare.Exercitiul1();//apeleaza metoda 'Exercitiul1' din clasa 'Rezolvare'
                Console.WriteLine(" ");
            }
            else if (raspuns == 2)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 2: Implement an algorithm to determine if a string has all unique characters.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul2();//apeleaza metoda 'Exercitiul2' din clasa 'Rezolvare'
                Console.WriteLine(" ");
            }
            else if (raspuns == 3)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 3: Write code to remove duplicates from an unsorted linked list.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul3();//apeleaza metoda 'Exercitiul2' din clasa 'Rezolvare'
                Console.WriteLine(" ");
            }
            else if (raspuns == 4)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 4: Write a function to check if a number is prime or not.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul4();//apeleaza metoda 'Exercitiul2' din clasa 'Rezolvare'
                Console.WriteLine(" ");
            }
            else if (raspuns == 5)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("     Homework4 - Exercitiul 5: Check if a word is a palindrome.");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Rezolvare.Exercitiul5();//apeleaza metoda 'Exercitiul2' din clasa 'Rezolvare'
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
