using System;
namespace ConsoleApplication
{
    public class ArrayUri
    {
        public static void Main()
        {
            int [] numbers = new int[5] {10, 11, 12, 13, 14};

            int [] aux = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int index = numbers.Length - i - 1;
                aux[numbers.Length - i - 1] = numbers[i];
            }
            WriteNumbers(aux);
            /*numbers[0] = 10;
            numbers[1] = 11;
            numbers[2] = 12;
            numbers[3] = 13;
            numbers[4] = 14;*/
            /*for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + ", ");
                }
            }*/

            Console.ReadLine();
        }
        public static void WriteNumbers (int [] aux)
        {
            for (int i = 0; i <= aux.Length - 1; i++)
            {
                if (i == aux.Length -1)
                {
                    Console.WriteLine(aux[i]);
                }
                else
                {
                    Console.WriteLine(aux[i] + ", ");
                }
            }
        }
    }
}