using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_EX._1_6
{
    public class Functie
    {
        public static Random _r = new Random();//cu ajutorul clasei Random alocam o valoare aleatorie variabilei _r
        public static int NrAleatorii(int no1)
        {
            int y = _r.Next(no1);//metoda Next aloca un nr aleatoriu < no1
            return y;
        }
        public static int[] GenIntArray(int lungime, int valoare)
        {
            int[] array1 = new int[lungime];
            int i = 1;
            while (i <= lungime)
            {
                int x = Functie.NrAleatorii(valoare);
                array1[i - 1] = x;
                //Console.WriteLine("   pos. {0} -- val. {1}", i.ToString(), x.ToString());
                i++;
            }
            return array1;
        }
    }
    public class Procedura
    {
        public static void MeniuPrincipal()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("   Returning to 'Main Menu'? y/n");
            string raspuns = Console.ReadLine();

            if (raspuns == "y")
                Program.Main();
            if (raspuns == "n")
                Console.WriteLine("   OK.");
            Console.WriteLine("-----------------------------------");
        }
        public static void AfisareIntArr(int[] intArr, string detalii)
        {
            Console.WriteLine(detalii);
            for (int i = 0; i <= intArr.Length - 1; i++)
                Console.WriteLine("   idx. {0}  ---   val. {1}", i.ToString(), intArr[i].ToString());
            Console.WriteLine("\n");
        }
    }
    public class Rezolvare
    {
        public static void Mod2Ex4()
        {
            Console.WriteLine("   We need to create an array in order to solve this exercise. OK? y/n");
            string raspuns = Console.ReadLine();

            if (raspuns == "n")
                Console.WriteLine("   Ok. Bye!");
            if (raspuns == "y")
            {
                Console.WriteLine("   How many elements do you want this array to have?");
                int lungUser = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("   Enter the max value the elements should have:");
                int valMaxUser = Convert.ToInt32(Console.ReadLine());

                int[] Array1 = new int[lungUser];
                Functie.GenIntArray(lungUser, valMaxUser).CopyTo(Array1,0);

                Procedura.AfisareIntArr(Array1, "   Array no. 1 elements: ");

                Console.WriteLine("   Enter the value of the element you want to remove:");
                int rmvElem = Convert.ToInt32(Console.ReadLine());

                int[] Array2 = new int[Array1.Length - 1];

                int j = 0;
                for (int i = 0; i <= Array1.Length - 1; i++)
                {
                    if (rmvElem != Array1[i])
                    {
                        Array2[j] = Array1[i];
                        j++;
                    }
                }
                Procedura.AfisareIntArr(Array2,"   Array no. 2 elements: ");
            }
            Procedura.MeniuPrincipal();
        }
        public static void Mod2Ex5()
        {
            Console.WriteLine("   We need to create an array in order to solve this exercise. OK? y/n");
            string raspuns = Console.ReadLine();

            if (raspuns == "n")
                Console.WriteLine("   Ok. Bye!");
            if (raspuns == "y")
            {
                Console.WriteLine("   How many elements do you want this array to have?");
                int lungUser = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("   Enter the max value the elements should have:");
                int valMaxUser = Convert.ToInt32(Console.ReadLine());

                int[] Array1 = new int[lungUser];
                Functie.GenIntArray(lungUser, valMaxUser).CopyTo(Array1, 0);

                Procedura.AfisareIntArr(Array1, "   Array no. 1 elements: ");

                Console.WriteLine("   Enter the index of the value you want to add:");
                int newIdx = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("   Enter the new value you want to add:");
                int newVal = Convert.ToInt32(Console.ReadLine());

                int[] Array2 = new int[Array1.Length +1];

                for (int i = 0; i <= Array1.Length - 1; i++)
                {
                    if (i < newIdx)
                        Array2[i] = Array1[i];
                    if (i == newIdx)
                    {
                        Array2[i] = newVal;
                        Array2[i + 1] = Array1[i];
                    }
                    if (i > newIdx)
                        Array2[i + 1] = Array1[i];
                }
                Procedura.AfisareIntArr(Array2 ,"   Array no. 2 elements: ");
            }
            Procedura.MeniuPrincipal();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("   Enter the number of the exercise you want to test! (4 or 5)");
            Console.WriteLine("        Module2-Ex.4. Remove a specific element from an array.");
            Console.WriteLine("        Module2-Ex.5. Insert an element into an array at a specified position.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            int raspuns = Convert.ToInt32(Console.ReadLine());

            if (raspuns == 4)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("        Ex. 4. Remove a specific element from an array.");
                Console.WriteLine("---------------------------------------------------------------------------");
                Rezolvare.Mod2Ex4();
                Console.WriteLine("\n");
            }
            else if (raspuns == 5)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("        Ex. 5. Insert an element into an array at a specified position.");
                Console.WriteLine("---------------------------------------------------------------------------");
                Rezolvare.Mod2Ex5();
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("   FINISH!!   ");
            }
            Console.ReadLine();
        }
    }
}
