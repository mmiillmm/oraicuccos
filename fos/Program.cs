using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraicuccos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("nem emlékszek a cuccra");

            Console.Write("A szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam >= 10 && szam < 20)
            {
                for (int i = 10; i < szam + 1; i++)
                {
                    Console.WriteLine(i);
                }
            }

            if (szam <= 10 && szam > -1)
            {
                while (szam < 10 && szam >= -1)
                {
                    Console.WriteLine(szam--);
                }
            }
            Console.ReadLine();

            //Console.WriteLine("Ez a program megadja a szám osztóit");

            //Console.Write("Szám: ");

            //int szam2 = Convert.ToInt32(Console.ReadLine());

            //if (szam2 % 1 == 0)
            //{
            //    Console.WriteLine(1);
            //}

            //if (szam2 % 2 == 0)
            //{
            //    Console.WriteLine(2);
            //}

            //if (szam2 % 5 == 0)
            //{
            //    Console.WriteLine(5);
            //}

            //if (szam2 % 10 == 0)
            //{
            //    Console.WriteLine(10);
            //}

            //if (szam2 % 50 == 0)
            //{
            //    Console.WriteLine(50);
            //}

            //if (szam2 % 100 == 0)
            //{
            //    Console.WriteLine(100);
            //}
            //Console.ReadLine();
        }
    }
}
