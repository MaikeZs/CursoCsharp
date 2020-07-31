using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maioridade
{
    class Program
    {
        static void Main(string[] args)
        {
            //ler idade como string
            Console.WriteLine("Qual e sua Idade ?");
            string entrada = Console.ReadLine();
            int a = Int32.Parse(entrada);
            //converter para int

            //verificar se a idade é maior ou igual a 18
            if (a >= 18)
            {
                Console.WriteLine("Mair de Idade");

            }
            else 
            {
                Console.WriteLine("Menor de Idade");
            }

            //Se sim
            // escrever Maior de idade

            //se nao
            // escrever Menor de idade

            Console.ReadLine();
        }
    }
}
