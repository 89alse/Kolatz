using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolatz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj:");
            
            int broj = int.Parse(Console.ReadLine());

            while (broj != 1)
            {
                if (broj % 2 == 0)
                {
                    broj = broj / 2;
                    Console.WriteLine(broj);
                 
                }
                else
                {
                    broj = broj * 3 + 1;
                    Console.WriteLine(broj);
                }
            }
            Console.ReadKey();
        }
    }
}
