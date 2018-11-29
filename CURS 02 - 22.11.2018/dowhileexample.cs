using System;
namespace Curs2
{
    public class DoWhileExample
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(number);
                number --;//musai spatiu intre variabila si operatie
            } while (number > 0);
        }
    }
}