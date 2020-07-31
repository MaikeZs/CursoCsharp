using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int numero = 3;
            for(numero=1;numero<=1000;numero++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero+ " E par " );
                }
            }*/

            int fatorial = 6;
            int Multiplicador;
            int Total = 1;
            for (Multiplicador = 1; Multiplicador <= fatorial; Multiplicador++) 
            {
                Total *= Multiplicador;
                
            
            }

            Console.WriteLine($"O Fatorial de {fatorial} é {Total}");
            
            Console.ReadLine();
        }
    }
}
