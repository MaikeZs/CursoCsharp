using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeDoisNUmero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor A:");
            string entrada = Console.ReadLine();
            int a = Int32.Parse(entrada);

            Console.WriteLine("Informe o valor B:");
            string entrada2 = Console.ReadLine();
            int b = Int32.Parse(entrada2);
            int saida = a + b;


            Console.WriteLine("resultado e " +saida);


            Console.ReadLine();
        }
    }
}
