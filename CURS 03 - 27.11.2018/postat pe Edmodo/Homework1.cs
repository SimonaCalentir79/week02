using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Homework1
    {
        static void Main(string[] args)
        {
            Console.Write("Pentru toate numerele de la 1 la 1000, se va afisa 'Fizz' daca numarul este divizibil cu 3, 'Buzz' daca numarul este divizibil cu 5, 'FizzBuzz' daca numarul este divizibil cu ambele si numarul ca atare daca acesta nu este divizibil nici cu 3, nici cu 5.");
            Console.WriteLine("Testam? y/n");
            string raspuns = Console.ReadLine();
            if (raspuns == "y")
            {
                int x = 1;
                for (x = 1; x <= 1000; x++)
                {
                    if (x % 3 == 0 && x % 5 == 0)
                        Console.Write("FizzBuzz -- ");
                    if (x % 3 == 0 && x % 5 != 0)
                        Console.Write("Fizz -- ");
                    if (x % 5 == 0 && x % 3 != 0)
                        Console.Write("Buzz -- ");
                    if (x % 3 != 0 && x % 5 != 0)
                        Console.Write(x.ToString() + " -- ");
                }
            }
            else
            {
                Console.WriteLine("OK. La revedere!");
            }
            
            Console.ReadLine();
        }
    }
}
