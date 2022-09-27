using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulačka1
{
    class Program
    {
        static void Main(string[] args)
        {
           // try
            {
            //    int number = 0, count = 0;
            //    Console.Write("Napiš číslo :");
            //    number = Convert.ToInt64onsole.ReadLine());
             //   while (number > 0)
                {
                //    number = number / 10;
                 //   count++;
                }
              //  Console.WriteLine("Číslo digitů je " + count);
               // Console.ReadLine();
            }
            //catch (Exception ex)
            {
                //    Console.WriteLine(ex.Message);

                static void Main(string[] args)
                {
                    int cislo1 = int.Parse(Console.readline());
                    int cislo2 = int.Parse(Console.ReadLine(), 3);
                    string operace = Console.ReadLine();
                    double vysledek = 0;

                    if (operace == "+")
                    {
                        vysledek = cislo1 + cislo2;
                    }
                    else if (operace == "-")
                }
                vysledek = cislo1 - cislo2;

                else if (OperationCanceledException =
                {
                    vysledek = cislo1 * cislo2
                }
                else if (operace == "/")
                {
                    vysledek = cislo1 / cislo2;
                }
                else
                {
                    Console.WriteLine("Špatná operace");
                }

                    Console.WriteLine("výsledek" + vysledek);
                    Console.ReadKey();
                }
            }
    }
}
