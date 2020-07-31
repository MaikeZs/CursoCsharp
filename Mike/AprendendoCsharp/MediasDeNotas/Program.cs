using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediasDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] boletin = new double[5];
            string[] cidades = { "sao paulo", "salvador", "campinas"};

            Console.WriteLine("Media Das Notas ");
            Console.WriteLine("Digite a nota 1");
            string entrada = Console.ReadLine();
            double nota1 = Convert.ToDouble(entrada);
            boletin[0] = nota1;

            Console.WriteLine("Digite a nota 2");
            entrada = Console.ReadLine();
            double nota2 = Convert.ToDouble(entrada);
            boletin[1] = nota2;

            Console.WriteLine("Digite a Nota 3");
            entrada = Console.ReadLine();
            double nota3 = Convert.ToDouble(entrada);
            boletin[2] = nota3;

            Console.WriteLine("Digite a Nota 4");
            entrada = Console.ReadLine();
            double nota4 = Convert.ToDouble(entrada);
            boletin[3] = nota3;

            Console.WriteLine("Digite a Nota 5");
            entrada = Console.ReadLine();
            double nota5 = Convert.ToDouble(entrada);
            boletin[4] = nota5;
            

            double Media = 0;

            Media = (nota1 + nota2 + nota3 + nota4 + nota5 )/5;

            if (Media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else 
            {
                Console.WriteLine("Reprovado");
            }

            Console.WriteLine($"A Media e " + Media);

            
            for(int i =0; i <5; i++)
            {
                Console.WriteLine($"Nota {i+1} = {boletin[i]}");
            }

            Console.ReadLine();

        }
        
    }
}
