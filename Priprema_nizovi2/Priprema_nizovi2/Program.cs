using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_nizovi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, isti=0, max;
            int[] niz1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] niz2 = { 3, 2, 8, 5, 5, 7 };

            do
            {
                if(niz1.Length<niz2.Length)
                {
                    max = niz1.Length;
                }
                else
                {
                    max = niz2.Length;
                }
                if (niz1[i] == niz2[i])
                {
                    isti++;
                }

                i++;
            } while (i < max);

            Console.WriteLine("Broj članova istih vrijednosti je " + isti);
            Console.ReadKey();
        }
    }
}
