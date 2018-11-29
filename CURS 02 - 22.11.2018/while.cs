using System;
namespace Curs2
{
    public class WhileExample
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            while(number > 0)
            {
                //Console.Write(number + ", ");
                Console.Write(number + "\t");
                //Console.WriteLine(number);
                number--;
            }
        }
    }
}