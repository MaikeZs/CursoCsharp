using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imposto_de_renda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 100.01;


            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("e pode deduzir na declaração o valor de R$ 142;");
            }
            else if (salario <= 3751.0)
            {
                Console.WriteLine("o IR é de 15% e pode deduzir R$ 350;");
            }

            else if (salario <= 4664.00) 
            {
                Console.WriteLine("o IR é de 22.5% e pode deduzir R$ 636.");
            }


            int idade = 12;
            double maioridade = 12;
            int centenario = 100;

            if(idade>=maioridade)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("Menor de idade");





















            Console.ReadLine();
        }
    }
}
