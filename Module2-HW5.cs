using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW5
{
    public class Metoda
    {
        public static void AfisareArr(int[] newArr)//afiseaza continutul unui array
        {
            Console.WriteLine("\n");
            Console.WriteLine("   Our collection contains the following elements:");
            Console.WriteLine("\n");
            foreach (var x in newArr )
                Console.Write("   {0} ",x.ToString());
            Console.WriteLine("\n");
        }
        public static void AfisareArr(string[] newArr)//afiseaza continutul unui array
        {
            Console.WriteLine("\n");
            Console.WriteLine("   Our collection contains the following elements:");
            Console.WriteLine("\n");
            foreach (var x in newArr)
                Console.Write("   {0} ", x.ToString());
            Console.WriteLine("\n");
        }
        public static void AfisareList(List<int> newList,string detalii)//afiseaza continutul unui array
        {
            Console.WriteLine("\n");
            Console.WriteLine(detalii);
            Console.WriteLine("\n");
            foreach (var x in newList)
                Console.Write("   {0} ", x.ToString());
            Console.WriteLine("\n");
        }
        public static void AfisareList(List<string> newList)//afiseaza continutul unui array
        {
            Console.WriteLine("\n");
            Console.WriteLine("   Our collection contains the following elements:");
            Console.WriteLine("\n");
            foreach (var x in newList)
                Console.Write("   {0} ", x.ToString());
            Console.WriteLine("\n");
        }
        public static void AfisareLkList(LinkedList<int> newList)//afiseaza continutul unui array
        {
            //Console.WriteLine("\n");
            Console.WriteLine("   Our collection contains the following elements:");
            Console.WriteLine("\n");
            foreach (var x in newList)
                Console.Write("   {0} ", x.ToString());
            Console.WriteLine("\n");
        }
        public static void AfisareLkList(LinkedList<string> newList)//afiseaza continutul unui array
        {
            //Console.WriteLine("\n");
            Console.WriteLine("   Our collection contains the following elements:");
            Console.WriteLine("\n");
            foreach (var x in newList)
                Console.Write("   {0} ", x.ToString());
            Console.WriteLine("\n");
        }
        public static int CalculeazaArmstrong(List<int> lstCifre)
        {
            int x = 0;
            int suma = 0;
            for (int i = 0; i < lstCifre.Count; i++)
            {
                x = Metoda.CalculeazaPutere(lstCifre[i], lstCifre.Count);
                Console.WriteLine("   cifra: {0} -- puterea: {1} -- valoarea: {2}", lstCifre[i].ToString(), lstCifre.Count.ToString(), x.ToString());
                suma = suma + x;
            }
            Console.WriteLine("\n");
            Console.WriteLine("   The sum of numbers above is: {0}", suma.ToString());
            Console.WriteLine("\n");
            return suma;
        }
        public static int CalculeazaPutere(int nr, int exp)
        {
            int produs = nr;
            for (int i = exp; i > 1; i--)
                produs = produs * nr;
            return produs;
        }
        public static List<int> EliminaDuplicate(int[] arr)//returneaza lista cu valorile distincte
        {
            List<int> lstUnice = new List<int>();
            for (int x = 0; x < arr.Length; x++)
            {
                int count = 0;
                if (Metoda.Exista(arr[x], lstUnice) == true)//(lstUnice.Contains(newArr[x]))
                    continue;
                lstUnice.Add(arr[x]);
                for (int y = 0; y < arr.Length; y++)
                {
                    if (arr[x] == arr[y])
                        count++;
                }
                if (count == 1)
                    Console.WriteLine("   Item {0} is unique.", arr[x].ToString());
                if (count != 1)
                    Console.WriteLine("   Item {0} appears {1} times.", arr[x], count.ToString());//cum fac sa nu mai afiseze de 'n' ori ca un nr anume se repeta de 'n' ori?
                                                                                                  //lstUnice.Remove(arr[x]);//daca e sa scot aceasta linie si acoladele de la if si sa ramana doar cw ca la if-ul anterior, se rezolva pb, insa am nevoie de Remove...
            }
            return lstUnice;
        }
        public static List<string> EliminaDuplicate(string[] arr)//returneaza lista cu valorile distincte
        {
            List<string> lstUnice = new List<string>();
            for (int x = 0; x < arr.Length; x++)
            {
                int count = 0;
                if (Metoda.Exista(arr[x].ToString(), lstUnice) == true)//(lstUnice.Contains(newArr[x]))
                    continue;
                lstUnice.Add(arr[x].ToString());
                for (int y = 0; y < arr.Length; y++)
                {
                    if (arr[x].ToString() == arr[y].ToString())
                        count++;
                }
                if (count == 1)
                    Console.WriteLine("   Item {0} is unique.", arr[x].ToString());
                if (count != 1)
                    Console.WriteLine("   Item {0} appears {1} times.", arr[x], count.ToString());//cum fac sa nu mai afiseze de 'n' ori ca un nr anume se repeta de 'n' ori?
                                                                                                  //lstUnice.Remove(arr[x]);//daca e sa scot aceasta linie si acoladele de la if si sa ramana doar cw ca la if-ul anterior, se rezolva pb, insa am nevoie de Remove...
            }
            return lstUnice;
        }
        public static bool Exista(int x, List<int> newList)//verifica existenta unei valori intr-o lista
        {
            bool exista = false;
            for (int i = 0; i < newList.Count; i++)
            {
                if (x == newList[i])
                    exista = true;
            }
            //Console.WriteLine("   Value {0} has variable 'exista' = {1}", x.ToString(), exista.ToString());
            return exista;
        }
        public static bool Exista(string x, List<string> newList)//verifica existenta unei valori intr-o lista
        {
            bool exista = false;
            for (int i = 0; i < newList.Count; i++)
            {
                if (x == newList[i])
                    exista = true;
            }
            //Console.WriteLine("   Value {0} has variable 'exista' = {1}", x.ToString(), exista.ToString());
            return exista;
        }
        public static int FactorialIterativ(int[] arr)//calculeaza factorialul unui numar prin iteratie
        {
            int fact = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    fact = fact * arr[i];
            }
            return fact;
        }
        public static int FactorialRecursiv(int nr)//calculeaza factorialul unui numar prin recursivitate
        {
            int fact = 0;
            if (nr == 1)
            {
                return 1;
            }
            else
            {
                fact = nr * FactorialRecursiv(nr - 1);
            }
            return fact;
        }
        public static List<int> FibIterativ(int limita)
        {
            List<int> lstFibb = new List<int>();
            int y = 0;
            lstFibb.Add(0);
            lstFibb.Add(1);
            for (int x = 2; x < limita; x++)
            {
                y = lstFibb[x - 1] + lstFibb[x - 2];
                lstFibb.Add(y);
            }
            return lstFibb;
        }
        public static int[] GenIntArray(int lungArr, int valArr)//genereaza un array integer cu lungime si valori specificate de utilizator
        {
            int[] newArr = new int[lungArr];
            for (int i = 0; i < lungArr; i++)
            {
                newArr[i] = NrAleatoriu(valArr);
            }
            return newArr;
        }
        public static int[] GenIntArray(int numar)//genereaza un array cu valorile consecutive mai mici ale numarului specificat de utilizator
        {
            int[] termeniAdd = new int[numar + 1];
            for (int i = 0; i <= numar; i++)
            {
                termeniAdd[i] = i;
            }
            return termeniAdd;
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
        public static List<int> GenIntList(int lungList, int valList)//genereaza o lista integer cu lungime si valori specificate de utilizator
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < lungList; i++)
            {
                newList.Add(NrAleatoriu(valList));
            }
            return newList;
        }
        public static List<int> GenIntListaCifre(int numar)//genereaza lista cifrelor unui nr introdus de utilizator
        {
            int rest = numar;
            int cifra = 0;
            List<int> lstCifre = new List<int>();
            while (rest != 0)
            {
                cifra = rest % 10;
                lstCifre.Add(cifra);
                rest = rest / 10;
            }
            return lstCifre;
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
        public static Random r = new Random();//variabila r primeste o valoare Random
        public static int NrAleatoriu(int nr)//genereaza un nr aleatoriu
        {
            int x = r.Next(nr);//variabila x primeste valoarea alocata lui r < nr
            return x;
        }
        public static int PrelParamInt()//preia si returneaza valoarea introdusa de utilizator
        {
            Console.WriteLine(" Enter a number:");
            int numar = Convert.ToInt32(Console.ReadLine());
            return numar;
        }
        public static void PrelParamInt(out int lungArr, out int valArr)//preia si returneaza valorile introduse de utilizator
        {
            Console.WriteLine("\n");
            Console.WriteLine("   We will create an Array or a List<T> in order to solve the problem!");
            Console.WriteLine("\n");
            Console.WriteLine("   How many elements do you want this one to have?");
            lungArr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("   Which is the max value an element should have?");
            valArr = Convert.ToInt32(Console.ReadLine());
        }
        public static int SumaNrPareArr(int[] newArr)//calculeaza suma nr pare dintr-un array
        {
            int suma = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] % 2 == 0)
                    suma = suma + newArr[i];
            }
            return suma;
        }
        public static int SumaCifreRecursiv(int nr)
        {
            int sumaCifre = 0;
            int x = nr / 10;
            if (nr == 0)
            {
                return 0;
            }
            else
            {
                sumaCifre = nr % 10 + SumaCifreRecursiv(x);//restul impartirii la 10 + restul restului impartirii la 10 + restul restului restului...
            }
            return sumaCifre;
        }
        public static int[] SortareIntArray(int[] arr)
        {
            int pozMin, x;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                pozMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pozMin])
                    {
                        pozMin = j;
                    }
                }
                if (pozMin != i)
                {
                    x = arr[i];
                    arr[i] = arr[pozMin];
                    arr[pozMin] = x;
                }
            }
            return arr;
        }
    }
    public class Rezolvare
    {
        public static void Exercitiul1()
        {
            Console.WriteLine("   Ex.1. Given an array of ints, write a C# method to total all the values that are even numbers.");

            int lungArr, valArr;
            Metoda.PrelParamInt(out lungArr, out valArr);

            int[] newArr = new int[lungArr];
            newArr = Metoda.GenIntArray(lungArr, valArr);

            Metoda.AfisareArr(newArr);

            Console.WriteLine("\n");
            Console.WriteLine("   The sum of the EVEN numbers is: {0}",Metoda.SumaNrPareArr(newArr).ToString());
        }
        public static void Exercitiul2()
        {
            Console.WriteLine("   Ex.2. How to find all pairs of elements in an integer array, ");
            Console.WriteLine("   whose sum is equal to a given number?");

            int numar = Metoda.PrelParamInt();

            int[] termeniAddArr = new int[numar + 1];
            //termeniAddArr = Metoda.GenIntArray(numar);//array ce contine toate nr de la 0 la nr introdus de utilizator
            termeniAddArr = Metoda.GenIntArray(numar, numar);//array cu continut aleatoriu, functie de nr introdus de utilizator

            List<int> lstDupl = new List<int>();

            Metoda.AfisareArr(termeniAddArr);

            for (int x = 0; x < termeniAddArr.Length; x++)//prima valoare din array, apoi a doua, ulterior a treia...
            {
                for (int y = 0; y < termeniAddArr.Length; y++)//comparata pe rand cu fiecare din valorile array-ului 
                {
                    if (Metoda.Exista(termeniAddArr[x],lstDupl)== true )//la prima rulare a buclei, aici e gol si trece peste
                    {                                      //incepand cu a doua, verifica daca exista in lista si sare la urmatoarea valoare
                        continue;
                    }
                    else
                    {
                        if (numar == termeniAddArr[x] + termeniAddArr[y])//daca indeplineste conditia
                        {
                            lstDupl.Add(termeniAddArr[x]);//sunt ambele adaugate in lista
                            lstDupl.Add(termeniAddArr[y]);
                            Console.WriteLine("\n");
                            Console.Write("   {0} = {1} + {2}", numar.ToString(), termeniAddArr[x].ToString(), termeniAddArr[y].ToString());
                        }
                    }
                }
            }
        }
        public static void Exercitiul3()
        {
            Console.WriteLine("   Ex.3. How to calculate factorial using recursion in C# + iterative + time difference.");

            int numar = Metoda.PrelParamInt();

            int[] factArr = new int[numar +1];
            factArr = Metoda.GenIntArray(numar);//.CopyTo(factArr,0);

            Metoda.AfisareArr(factArr);

            int x = Metoda.FactorialIterativ(factArr);
            int y = Metoda.FactorialRecursiv(numar);

            Console.WriteLine("\n");
            Console.WriteLine("   Iterative: !{0} = {1}", numar.ToString(), x.ToString());
            Console.WriteLine("   Recursive: !{0} = {1}", numar.ToString(), y.ToString());
        }
        public static void Exercitiul4()
        {
            Console.WriteLine("   Ex.4. Algorithm to find if Array contains duplicates?");

            int lungArr, valArr;
            Metoda.PrelParamInt(out lungArr , out valArr);

            int[] newArr = new int [lungArr];
            newArr = Metoda.GenIntArray(lungArr, valArr);

            Metoda.AfisareArr(newArr);

            List<int> lstUnicate = new List<int>();
            lstUnicate = Metoda.EliminaDuplicate(newArr);
        }
        public static void Exercitiul5()
        {
            Console.WriteLine("   Ex.5. How to remove duplicates from a sorted linked list?");

            int lungime, valMax;
            Metoda.PrelParamInt(out lungime , out valMax );

            int[] arrayNou = new int[lungime];
            arrayNou = Metoda.GenIntArray(lungime,valMax);

            List<int> listaUnice = new List<int>();
            listaUnice = Metoda.EliminaDuplicate(arrayNou);

            Console.Write("   All the elements of the initial list...");
            Metoda.AfisareArr(arrayNou);
            Metoda.AfisareList(listaUnice, "   Unique elements of the list...");
        }
        public static void Exercitiul6()
        {
            Console.WriteLine("   Ex.6. How to find sum of digits of a number using Recursion?");

            int numar = Metoda.PrelParamInt();
            int sumaCifre = Metoda.SumaCifreRecursiv(numar);

            Console.WriteLine("   The number you entered is {0} and it's digits sum is: {1}", numar.ToString(),sumaCifre.ToString());
        }
        public static void Exercitiul7()
        {
            Console.WriteLine("   Ex.7. Given an unsorted array which has a number in the majority");
            Console.WriteLine("   (a number appears more than 50% in the array), find that number?");

            int lungime, valMax;
            Metoda.PrelParamInt(out lungime, out valMax);

            int[] arr = new int[lungime];
            arr = Metoda.GenIntArray(lungime, valMax);

            List<int> lstUnice = new List<int>();

            for (int x = 0; x < arr.Length; x++)
            {
                int count = 0;
                if (Metoda.Exista(arr[x], lstUnice) == true)//(lstUnice.Contains(newArr[x]))
                    continue;
                lstUnice.Add(arr[x]);
                for (int y = 0; y < arr.Length; y++)
                {
                    if (arr[x] == arr[y])
                        count++;
                }
                if (count == 1)
                    Console.WriteLine("   Item {0} is unique.", arr[x].ToString());
                if (count != 1)
                    Console.WriteLine("   Item {0} appears {1} times.", arr[x], count.ToString());
                if (count > arr.Length/2)
                    Console.WriteLine("   Item {0} is in majority!",arr[x]);
            }
        }
        public static void Exercitiul8()
        {
            Console.WriteLine("   Ex.8. How to detect a cycle in singly linked list?");

            Console.WriteLine("   Sorry! Couldn't solve it!");
        }
        public static void Exercitiul9()
        {
            Console.WriteLine("   Ex.9. How to merge two sorted linked list?");

            int lungime, valMax;
            Metoda.PrelParamInt(out lungime, out valMax);//preluam lungimea si val maxima de la utilizator

            List<int> list1 = new List<int>();
            list1 = Metoda.GenIntList(lungime, valMax);//generam prima lista cu elem aleatorii

            List<int> list2 = new List<int>();
            list2 = Metoda.GenIntList(lungime ,valMax);//generam a doua lista cu elem aleatorii

            Metoda.AfisareList(list1,"   List1 elements: ");
            Metoda.AfisareList(list2,"   List2 elements: ");

            int[] arrList1 = new int[list1.Count];//initializam 2 array-uri pentru a copia in ele elementele celor 2 liste de mai sus
            int[] arrList2 = new int[list2.Count];//ca sa putem folosi metoda 'EliminaDuplicate'
            

            for (int i = 0; i < list1.Count; i++)//populam primul array cu elem. din prima lista
                arrList1[i] = list1[i];
            //Metoda.AfisareArr(arrList1);

            for (int i = 0; i < list2.Count; i++)//populam al doilea array cu elem. din a doua lista
                arrList2[i] = list2[i];
            //Metoda.AfisareArr(arrList2);

            List<int> listaUnice1 = new List<int>();//initializam 2 liste in care sa stocam valorile unice
            List<int> listaUnice2 = new List<int>();

            listaUnice1 = Metoda.EliminaDuplicate(arrList1);//populam prima lista cu unicate, folosind metoda 'EliminaDuplicate'
            listaUnice2 = Metoda.EliminaDuplicate(arrList2);//populam a doua lista cu unicate, folosind metoda 'EliminaDuplicate'

            Metoda.AfisareList(listaUnice1, "   Lista unice 1: ");
            Metoda.AfisareList(listaUnice2, "   Lista unice 2: ");

            List<int> mergedList = new List<int>();//initializam lista cu valorile unite ale celor doua liste de unicate
            for (int i = 0; i < listaUnice1.Count; i++)
            {
                mergedList.Add(listaUnice1[i]);//populam lista unita cu valorile din prima lista de unicate
            }
            for (int i = 0; i < listaUnice2.Count; i++)
            {
                if (Metoda.Exista(listaUnice2[i], mergedList) == false)//daca valorile din lista a doua de unicate nu exista deja in lista unita
                    mergedList.Add(listaUnice2[i]);//le adaugam si pe acestea
            }
            Metoda.AfisareList(mergedList,"   Merged list elements are: ");
        }
        public static void Exercitiul10()
        {
            Console.WriteLine("   Ex.10. Write a Program which checks if two Strings are Anagram or not?");

            Console.WriteLine("   Enter the first few letters: ");
            string firstString = Console.ReadLine();

            Console.WriteLine("   Enter the second string:");
            string secondString = Console.ReadLine();

            string[] arrFirst = new string[firstString.Length];
            arrFirst = Metoda.GenStrArray(firstString);

            string[] arrSecond = new string[secondString.Length];
            arrSecond = Metoda.GenStrArray(secondString);

            Array.Sort(arrFirst);
            Array.Sort(arrSecond);

            int counter = 0;
            for (int i = 0; i < arrFirst.Length; i++)
            {
                if (arrFirst[i] != arrSecond[i])
                    counter--;
                if (arrFirst[i] == arrSecond[i])
                    counter++;
            }
            if (counter == arrFirst.Length && counter == arrSecond.Length)
                Console.WriteLine("   The two strings are ANAGRAM!");
            if (counter != arrFirst.Length)
                Console.WriteLine("   The two strings are NOT anagram!");
        }
        public static void Exercitiul11()
        {
            Console.WriteLine("   11. Write a function to print nth number in Fibonacci series?");

            int nr = 0;
            nr = Metoda.PrelParamInt();

            List<int> lstFibonacci = new List<int>();
            lstFibonacci = Metoda.FibIterativ(nr);

            Metoda.AfisareList(lstFibonacci,"   Fibonacci numbers are: ");

            int z = 0;
            for (int x = 0; x < lstFibonacci.Count; x++)
            {
                if (x == nr-1)
                    z = lstFibonacci[x];
            }
            Console.WriteLine("   Al {0}-lea numar din sirul lui Fibonacci este: {1}",nr.ToString(),z.ToString());
        }
        public static void Exercitiul12()
        {
            Console.WriteLine("   12. Write a function to count a total number of set bits in a 32 bit Integer?");

            Console.WriteLine("   Enter an integer:");
            int numar = Convert.ToInt32(Console.ReadLine ());

            int counter = 0;
            List<int> binar = new List<int>();

            while (numar > 0)
            {
                //Console.Write("{0} ", (numar % 2).ToString());
                binar.Add(numar%2);
                if ((numar % 2) == 1)
                    counter++;
                numar = numar / 2;
            }
            binar.Reverse();
            Metoda.AfisareList(binar, "   Binary form of the number you entered is: ");
            Console.WriteLine("\n");
            Console.WriteLine("   Total number of set bits is: {1}", numar.ToString (),counter.ToString ());
        }
        public static void Exercitiul13()
        {
            Console.WriteLine("   13. Write a function to remove duplicate characters from String?");

            Console.WriteLine("   Enter a few repetitive letters:");
            string litere = Console.ReadLine();

            string[] arrLitere = new string[litere.Length];
            arrLitere = Metoda.GenStrArray(litere);

            Metoda.AfisareArr(arrLitere);

            List<string> lstUnice = new List<string>();
            lstUnice = Metoda.EliminaDuplicate(arrLitere);

            Metoda.AfisareList(lstUnice);
        }
        public static void Exercitiul14()
        {
            Console.WriteLine("   Ex.14. How to find the 3rd element from end, in a singly linked, in a single pass?");

            Console.WriteLine("   Sorry! Couldn't solve it!");
        }
        public static void Exercitiul15()
        {
            Console.WriteLine("   15. C# program to check if a number is Armstrong number or not?");

            Console.WriteLine("   Enter a number to check for Armstrong property: ");
            int numar = Convert.ToInt32(Console.ReadLine ());

            List<int> lstCifre = new List<int>();
            lstCifre = Metoda.GenIntListaCifre(numar);

            Metoda.AfisareList(lstCifre,"   Digits list is: ");

            int nrArm = Metoda.CalculeazaArmstrong(lstCifre);

            if (numar == nrArm)
                Console.WriteLine("   The number you entered is an Armstrong number!");
            if (numar != nrArm)
                Console.WriteLine("   The number you entered is NOT an Armstrong number!");
        }
        public static void Exercitiul16()
        {
            Console.WriteLine("   16. Algorithm to check if a number is Prime or not?");
            
            //pentru a afla daca un nr este prim, acestuia ii trebuie verificata divizibilitatea cu toate nr prime mai mici decat el
            Console.WriteLine("   Enter the number to check!");
            Console.WriteLine("   (Please, choose a number < 10.000 if you want the result today :) )");
            int numar = Convert.ToInt32(Console.ReadLine());//preluare valoare utilizator in var. numar

            int[] arrNumere = new int[numar];//array-ul arrNumere creat prin
            arrNumere = Metoda.GenIntArray2(numar);//apelarea functiei 'GenIntArray' din clasa 'Metoda'

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
                Console.WriteLine("   Number {0} is prime!", numar.ToString());
            //Metoda.AfisareList(lstPrime);
        }
        public static void Exercitiul17()
        {
            Console.WriteLine("   Ex.17. Algorithm to check if a number is Palindrome?");

            Console.WriteLine("   Enter a number to check for 'palindrome' property: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            List<int> listaCifre = new List<int>();
            listaCifre = Metoda.GenIntListaCifre(numar);
            Metoda.AfisareList(listaCifre,"   Digits list is: ");

            List<int> listaPeDos = new List<int>();
            for (int i = 0; i < listaCifre.Count; i++)
                listaPeDos.Add(listaCifre[listaCifre.Count - 1 - i]);
            Metoda.AfisareList(listaPeDos,"   Reversed digits list is: ");

            int counter = 0;
            for (int j = 0; j < listaCifre.Count; j++)
            {
                if (listaCifre[j] == listaPeDos[j])
                    counter++;
                if (listaCifre[j] != listaPeDos[j])
                    counter--;
            }
            if (listaCifre.Count == counter)
                Console.WriteLine("   Number {0} is a palindrome!", numar.ToString());
            if (listaCifre.Count != counter )
                Console.WriteLine("   Number {0} is NOT a palindrome!", numar.ToString());
        }
        public static void Exercitiul18()
        {
            Console.WriteLine("   Ex.18. Write code to reverse a linked list, if you able to do it using loops,");
            Console.WriteLine("   try to solve with recursion?");

            Console.WriteLine("   Enter some letters to reverse them: ");
            string litere = Console.ReadLine();

            string[] arrLitere = new string[litere.Length];
            arrLitere = Metoda.GenStrArray(litere);

            LinkedList<string> lstCuvinte = new LinkedList<string>(arrLitere);
            Console.WriteLine("   The initial list of the letters you entered...");
            Metoda.AfisareLkList(lstCuvinte);

            LinkedList<string> lstPeDos = new LinkedList<string>();
            for (int i = 0; i < arrLitere.Length; i++)
            {
                lstPeDos.AddLast(arrLitere[arrLitere.Length - 1 - i]);
            }
            Console.WriteLine("   The reversed list of the letters...");
            Metoda.AfisareLkList(lstPeDos);
            //varianta recursiva va trebui sa o discutam la curs
        }
        public static void Exercitiul19()
        {
            Console.WriteLine("   19. How to rotate an array by a given pivot ?");

            int lungime, valMax;
            Metoda.PrelParamInt(out lungime , out valMax);

            int[] arrInitial = new int[lungime];
            arrInitial = Metoda.GenIntArray(lungime ,valMax);
            Metoda.AfisareArr(arrInitial);

            Console.WriteLine("   Enter a value with the role of 'pivot':");
            int pivot = Convert.ToInt32(Console.ReadLine());

            int x = 0;
            for (int i = 0; i < arrInitial.Length; i++)
            {
                if (pivot == arrInitial[i])
                    x = i;
            }
            Console.WriteLine("   The index of {0} is {1}.",pivot.ToString(),x.ToString ());

            List<int> lstRotit = new List<int> { };
            int j = 0;
            int k = 0;
            while (j < arrInitial.Length - x)
            {
                lstRotit.Add(arrInitial[j+x]);
                j++;
            }
            for (j = arrInitial.Length - x; j < arrInitial.Length; j++)
            {
                while (k < x)
                {
                    lstRotit.Add(arrInitial[k]);
                    k++;
                }
            }
            //Metoda.AfisareList(lstRotit);
            int[] arrRotit = new int[arrInitial.Length];
            lstRotit.CopyTo(arrRotit ,0);
            Metoda.AfisareArr(arrRotit);
        }
        public static void Exercitiul20()
        {
            Console.WriteLine("   20. Sorting an Array using Selection Sort");

            int lungime, valMax;
            Metoda.PrelParamInt(out lungime, out valMax);

            int[] arrNesortat = new int[lungime];
            arrNesortat = Metoda.GenIntArray(lungime,valMax);
            Metoda.AfisareArr(arrNesortat);

            Metoda.SortareIntArray(arrNesortat);

            Metoda.AfisareArr(arrNesortat);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("   Please select the number of an exercise: ");
            int nrEx = Convert.ToInt32(Console.ReadLine ());

            switch (nrEx)
            {
                case 1:
                    Rezolvare.Exercitiul1();
                    break;
                case 2:
                    Rezolvare.Exercitiul2();
                    break;
                case 3:
                    Rezolvare.Exercitiul3();
                    break;
                case 4:
                    Rezolvare.Exercitiul4();
                    break;
                case 5:
                    Rezolvare.Exercitiul5();
                    break;
                case 6:
                    Rezolvare.Exercitiul6();
                    break;
                case 7:
                    Rezolvare.Exercitiul7();
                    break;
                case 8:
                    Rezolvare.Exercitiul8();//de rezolvat
                    break;
                case 9:
                    Rezolvare.Exercitiul9();
                    break;
                case 10:
                    Rezolvare.Exercitiul10();
                    break;
                case 11:
                    Rezolvare.Exercitiul11();
                    break;
                case 12:
                    Rezolvare.Exercitiul12();
                    break;
                case 13:
                    Rezolvare.Exercitiul13();
                    break;
                case 14:
                    Rezolvare.Exercitiul14();//de rezolvat
                    break;
                case 15:
                    Rezolvare.Exercitiul15();
                    break;
                case 16:
                    Rezolvare.Exercitiul16();
                    break;
                case 17:
                    Rezolvare.Exercitiul17();
                    break;
                case 18:
                    Rezolvare.Exercitiul18();
                    break;
                case 19:
                    Rezolvare.Exercitiul19();
                    break;
                case 20:
                    Rezolvare.Exercitiul20();
                    break;
                default:
                    Console.WriteLine("  You need to enter the number of the problem if you want to start! (from 1 to 20)");
                    break;
            }
            Console.ReadLine();
        }
    }
}
