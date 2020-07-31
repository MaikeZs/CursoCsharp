using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinto
{
    class Program
    {
        static void Main(string[] args)
        {
           int idade = 20;

            int idade10= 64;
            bool ehIdoso = idade10 >= 65;

            Console.WriteLine(ehIdoso);

            if (idade >= 18)
            {
                Console.WriteLine("Seja-BemVidno(a)");
                Console.WriteLine("voce tem mais de 18,Pode entra.");
            }  

            else
            {
                Console.WriteLine("infelizmente voce nao pode entra.");
            }
            



            Console.ReadLine();
        }
    }
}
