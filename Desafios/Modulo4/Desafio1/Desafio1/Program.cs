using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] origen = { 1002, 104, 309, 500 };
            int[] destino = new int[origen.Length];
            int contador = 0;


            for (int i = origen.Length - 1; i >= 0; i--)
            {
                destino[contador] = origen[i];
                contador++;
            }
                

            foreach (int num in destino)
            {
                Console.WriteLine(num);
            }
            Console.Read();
                
        }
    }
}
