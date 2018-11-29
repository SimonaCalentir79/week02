using System;

namespace ConsoleApplication 
{
    public class EvenOdd 
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if(Modulo(number, 2) == 0)
            {
                Console.WriteLine("Number is even!");
            }
            else
            {
                Console.WriteLine("Number is odd!");
            }

        }

        public static int Modulo(int number1, int number2)
        {
            return number1 % number2;
        }
    } 
}