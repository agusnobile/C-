using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] vector = new int[12];//vector de 12 posiciones para la facturacion de todos los meses
            vector[0] = 1000;
            vector[1] = 2000;
            vector[2] = 3000;
            //6000
            vector[3] = 4000;
            vector[4]= 1000;
            vector[5] = 4000;
            //9000
            vector[6]= 3000;
            vector[7]= 1000;
            vector[8]= 3000;
            //7000
            vector[9]= 3000;
            vector[10]= 1000;
            vector[11] = 4000;
            //8000

            //genero otro vector de 4 posiciones para poner la facturacion trimestral
            int[] vector2=new int[4];
            

            for(int i=0;i<vector.Length;i++)
            {
                if (i<=2)
                {
                    vector2[0]= vector2[0] + vector[i];
                }
                if(i>2 & i<=5)
                {
                    vector2[1]= vector2[1]+ vector[i];
                }
                if(i>5 && i<=8)
                {
                    vector2[2] = vector2[2]+ vector[i]; 
                }
                if(i>8 && i <= vector.Length)
                {
                    vector2[3] = vector2[3]+ vector[i]; 
                }
                
               
            }
            for(int i = 0; i < vector2.Length; i++)
            {
                Console.WriteLine("Trimestre numero {0}",i+1);
                Console.WriteLine(vector2[i]);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            
        }
        
    }
}
