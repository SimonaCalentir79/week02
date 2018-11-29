using System;

namespace ConsoleApplication
{
    public class DisplayNumbers
    {
        public static void Main()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine (i);
                //i--;
            }
            Console.WriteLine ("--------------------");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine (i);
                //i++;
            }
            Console.WriteLine ("--------------------");
            /*bool goon = true;
            for (int i = 10; goon; i--)
            {
                
            }*/
        }
    }
}