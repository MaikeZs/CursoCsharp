using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main (string[] args)
        {
            
            Funcionario Maria = new JovermAprendiz();
            Maria.Salario = 750;
            Maria.CPF= " 555.555.555-8";
            Maria.AumentoDeSalario();
            

            Funcionario joao=new Gerente();
            joao.Nome = "Joao";
            joao.Salario = 3500;
            joao.AumentoDeSalario();

            Funcionario Jesus = new Diretor();
            Jesus.Salario = 5000;
            Jesus.AumentoDeSalario();

            Console.WriteLine("Aumento Do Salario Da Maria : "+Maria.Salario);
            Console.WriteLine("Bonificacao da Maria: " +Maria.GetBonificacao());
            Console.WriteLine("Aumento Do Salario Da Maria : " + joao.Salario);
            Console.WriteLine("Bonificacao da Maria: " + joao.GetBonificacao());
            Console.WriteLine("Aumento Do Salario Da Maria : " + Jesus.Salario);
            Console.WriteLine("Bonificacao da Maria: " + Jesus.GetBonificacao());




            Console.ReadLine();

           


        }
    }
}
