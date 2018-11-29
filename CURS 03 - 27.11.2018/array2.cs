using System;
namespace ConsoleApplication
{
    public class ArrayUri2
    {
        public static void Main()
        {
            int [] numbers = new int[5] {10, 11, 12, 13, 14};

            //int [] aux = new int[numbers.Length];

            /*for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int index = numbers.Length - i - 1;
                aux[numbers.Length - i - 1] = numbers[i];
            }*/
            int x;
            for (i = 0; i < numbers.Length / 2; i++)
            {
                //var index = numbers.Length - i -1;
                Swap(numbers, i, numbers.Length - i - 1);
                /*x = numbers[i];

                numbers[i] = numbers[index];
                numbers[index] = x;*/
            }
            //WriteNumbers(aux);
            WriteNumbers(numbers);
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
        /*public static void WriteNumbers (int [] aux)
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
        }*/
        public static void WriteNumbers (int [] numbers)
        {
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (i == numbers.Length -1)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    Console.WriteLine(numbers[i] + ", ");
                }
            }
        }
        public static void Swap(int[] arr, int i, int j)
        {
            var x = arr[i];
            arr[i] = arr[j];
            arr[j] = x;
        }
    }
}