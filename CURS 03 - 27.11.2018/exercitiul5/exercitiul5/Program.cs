using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiul5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de caractere!");
            var s = Console.ReadLine();

            var arr = s.ToCharArray();

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            //Console.WriteLine(arr.Reverse());
            Console.ReadLine();
        }
    }
}
