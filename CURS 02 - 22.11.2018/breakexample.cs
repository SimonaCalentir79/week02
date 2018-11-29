using System;
namespace Curs2
{
    public class BreakExample
    {
        public static void Main()
        {
            int i = 100;
            while (i > 0)
            {
                //i--;
                if (i % 7 == 0)
                {
                    ///break;
                    throw new Exception("It's over!");
                    //continue;
                }
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("Done!");
        }
    }
}