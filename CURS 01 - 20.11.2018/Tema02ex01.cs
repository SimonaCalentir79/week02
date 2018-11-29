using System;
namespace ConsoleApplication
{
    public class Tema02ex01 
    {
        public static void Main()
        {
            Console.WriteLine ("Please enter the first number: ");
            string temp1 = Console.ReadLine();

            Console.WriteLine ("Please enter the second number: ");
            string temp2 = Console.ReadLine();

            int nr1 = Convert.ToInt32(temp1);
            int nr2 = Convert.ToInt32(temp2);

            //VERSIUNEA 1 - tratarea erorii privind impartirea la 0
            /*try {
                Console.WriteLine("The result of division is: " + nr1 / nr2);
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Division by 0 is not possible!");
            }*/
            //------------------------------------------------------------------------------
            //VERSIUNEA 2 - tratarea erorii privind impartirea la 0
            if (nr2 == 0)
            {
                Console.WriteLine("Division by 0 is not possible!");
            }
            else
            {
                int vDivision = fDivision(nr1, nr2);//se apeleaza functia fDivision, de mai jos
                Console.WriteLine("The result of division is: " + vDivision.ToString ());
            }
            //------------------------------------------------------------------------------
            int  vMultiplication = fMultiplication(nr1, nr2);//se apeleaza functia fMultiplication, de mai jos
            Console.WriteLine("The result of multiplication is: " + vMultiplication.ToString ());
            //------------------------------------------------------------------------------
        }
        public static int fDivision (int no5, int no6)//functia pentru impartire
        {
            int vDivision = no5 / no6;
            return vDivision;
        }
        public static int fMultiplication (int no3, int no4)//functia pentru inmultire
        {

            int vMultiplication = no3 * no4;
            return vMultiplication;
        }
    }
}