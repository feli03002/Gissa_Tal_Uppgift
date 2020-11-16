using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gissa_Tal_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int tal, försök = 0, svar;
            tal = rng.Next(0, 101);
            while (true)
            {
                Console.WriteLine("gissa ett tal mellan 1 0ch 100");
                svar = Convert.ToInt32(Console.ReadLine());
                if (svar > tal)
                {
                    Console.WriteLine("För stort, försök igen!");
                    försök++;
                }
                else if(svar < tal)
                {
                    Console.WriteLine("För lågt, försök igen!");
                    försök++;
                }
                else
                {
                    Console.WriteLine("Rätt!");
                    Console.WriteLine("Det tog " + försök + "st försök");
                    break;
                }

            }
        }
    }
}
