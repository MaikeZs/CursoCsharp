using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //pedir para o usuario escrever ate quanto contaremos
           Console.WriteLine("Quer conta ate quando ?");
            string entrada = Console.ReadLine();
            int a = Int32.Parse(entrada);
            //ler valor informado pelo usuario

            //converter valor lido de string para int

            //iniciar um int contador zerado
            int contador =0;
            //enquanto o contador for menor ou igual valor informado
            while (contador >= a) 
            {
                Console.WriteLine( contador);

               contador--;
            }
            //escrever o valor do contador
            //somar 1 ao contador
            Console.ReadLine();
        }
    }
}
