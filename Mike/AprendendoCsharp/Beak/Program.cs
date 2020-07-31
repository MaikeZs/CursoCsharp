using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++) 
            {
                

                for (int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
                {
                    Console.Write(contadorColuna);
                    if(contadorColuna>=contadorLinha)
                    break;
                }

                Console.WriteLine();


            }


            int contador =1;

            while (contador <= 10)
            {
               
                
                Console.WriteLine(contador);
                contador++;
            }





            Console.ReadLine();
        }
    }
}
