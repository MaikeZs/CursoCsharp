using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sexto_TestaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 53;
            int qtd = 1;
            bool comCachorro = true;
            bool acompanhado = qtd>1 || comCachorro;

            Console.WriteLine(acompanhado);
            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja-BemVindo(a)");
            }

            else
            {

                Console.WriteLine("Infelizmente Nao Pode entra");
            }







            Console.ReadLine();

        }
    }
}
