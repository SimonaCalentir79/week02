using System;
namespace Curs2
{
    public class ContinueExample
    {
        public static void Main()
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 2 ==0)
                    {
                        continue;
                    }
                Console.WriteLine(i);
            }
        }
    }
}