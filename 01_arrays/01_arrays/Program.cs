using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];
            int i;
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("digite um número ({0}º Número)",i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 15; i++)
            {
                if (i%2 == 1)
                {
                    Console.Write( numeros[i]+ ",");
                }
            }
        }
    }
}
