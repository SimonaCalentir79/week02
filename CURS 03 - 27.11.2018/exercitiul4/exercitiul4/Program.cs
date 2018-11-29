using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiul4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberToGuess = new Random().Next(1, 10);
            //bool ok = true;
            while (true) //(ok == false)
            {
                Console.WriteLine("Introduceti un numar: ");
                var x = Convert.ToInt32(Console.ReadLine());

                if (x == numberToGuess)
                {
                    Console.WriteLine("Felicitari! Ati ghicit numarul!");
                    //ok = false;
                    break;
                }
                Console.WriteLine(x < numberToGuess 
                    ? "Numarul ales este prea mic!" 
                    : "Numarul introdus este prea mare!");
                    /*if (x < numberToGuess)
                    {
                        Console.WriteLine("Numarul ales este prea mic!");
                        Console.WriteLine("Mai incearca!");
                    }
                    else
                    {
                        Console.WriteLine("Numarul introdus este prea mare!");
                        Console.WriteLine("Mai incearca!");
                    }*/
                    //Console.WriteLine("Mai incearca!");
            }
            Console.ReadLine();
        }
    }
}
