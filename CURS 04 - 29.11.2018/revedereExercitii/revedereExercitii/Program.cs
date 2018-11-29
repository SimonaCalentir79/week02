using System;

namespace revedereExercitii
{
    class Program
    {
            static int FindIndex(int[] vstocNumere8, int value)
            {
                for (int i = 0; i < vstocNumere8.Length; i++)
                {
                    if (vstocNumere8[i] == value)
                        return i;
                }
                return -1;
            }
        public static int FindOccurencies(int[] array, int value)
        {
            int counter = 0;

            foreach (var element in array)
            {
                if (element == value)
                    counter++;
            }
            return counter;
        }
            static void Main(string[] args)
            {
            int[] arr = new[] { 1, 17, 2, 7, 2, 8 };
            int value = 2;
            int index = 3;

            int[] newArray = new int[arr.Length + 1];
            int counter = 0;
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = value;
                    counter++;
                }
                else
                {
                    newArray[i] = arr[i - counter];
                }
            }

            for (int i = 0; i < newArray.Length; i++)
                Console.WriteLine(newArray [i] + "");

            /*var index = FindIndex(arr, value);

            var occurencies = FindOccurencies(arr, value);

            //int[] newArray = new int[arr.Length - 1];
            int[] newArray = new int[arr.Length - occurencies];
            //int counter = -1;
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //if (i == index)
                //{
                //    continue;
                //}
                if (arr[i] == value)
                {
                    continue;
                }
                counter++;
                newArray[counter] = arr[i];
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + "");
            }

            Console.ReadLine();*/
            }
    }
}
