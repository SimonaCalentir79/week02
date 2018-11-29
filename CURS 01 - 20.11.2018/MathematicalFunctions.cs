using System;
namespace ConsoleApplication
{
    public class MathFunctions 
    {
        public static void Main()
        {
            Console.WriteLine ("Please add the first number: ");
            string temp1 = Console.ReadLine();

            Console.WriteLine ("Please add the second number: ");
            string temp2 = Console.ReadLine();

            int number1 = Convert.ToInt32(temp1);
            int number2 = Convert.ToInt32(temp2);

            //int sum = number1 + number2 ;
            int sum = Sum(number1, number2);//se apeleaza functia Sum, de mai jos
            int  subtraction = Subtraction(number1, number2);
            Console.WriteLine("The sum is: " + sum.ToString ());
            Console.WriteLine("The result of subtraction is: " + subtraction.ToString ());
        }
        public static int Sum (int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
            //return number1 + number2;
        }
        public static int Subtraction (int number1, int number2)
        {

            int subtraction = number1 - number2;
            return subtraction;
        }
    }
}