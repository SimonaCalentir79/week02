using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs29nov18
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("How many element you want to print");
            int n = Convert.ToInt32(Console.ReadLine ());
            for (int i = 0; i < n; i++)
            {
                int F = Fibonacci(i);
                Console.WriteLine(F);
            }
            Console.ReadLine();
        }
    }
    //stackoverflow
    //gen.rus.lib.ec --- C#
}
