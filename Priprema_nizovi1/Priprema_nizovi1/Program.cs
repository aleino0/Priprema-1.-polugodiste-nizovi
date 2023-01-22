 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_nizovi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;
            int[] niz1 = new int[10];
            int[] niz2 = new int[10];
            int kraj1=0, kraj2=0;

            do
            {
                
                Console.WriteLine("Unesite broj");
                broj = Convert.ToInt32(Console.ReadLine());
                if(broj%2==0)
                {
                    niz1[kraj1]=broj;
                    kraj1++;
                }
                else
                {
                    niz2[kraj2]=broj;
                    kraj2++;
                }
            } while (broj != 0 && kraj1<10 && kraj2<10);

            Console.WriteLine("Parni niz");
            for (int i = 0; i < kraj1; i++)
                Console.Write(niz1[i] + " ");
            Console.WriteLine("\nNe parni niz");
            for (int i = 0; i < kraj2; i++)
                Console.Write(niz2[i] + " ");

            Console.ReadKey();
        }
    }
}
