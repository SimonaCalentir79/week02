using System;
namespace Curs2
{
    public class ConvertExample
    {
        public static void Main()
        {
            //int a = (int) 3.56;
            int a = Convert.ToInt32(3.56);
            Console.WriteLine(a);
        }
    }
}