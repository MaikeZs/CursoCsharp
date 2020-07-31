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
            SistemaInterno Sistem = new SistemaInterno();
            
            Funcionario Maria = new JovermAprendiz(1000,"555.666.444-8");
            Maria.CPF= " 555.555.555-8";
            Maria.AumentoDeSalario();
           

            Autenticavel joao=new Gerente(10000,"888.888.888-8");
            joao.Nome = "Joao";
            joao.AumentoDeSalario();
            joao.Senha = "123";
            Sistem.Logar(joao,"123");
           

            
           Autenticavel Jesus = new Diretor(5000,"555.555.555-5");
            Jesus.AumentoDeSalario();
            Jesus.Senha = "456";
            Sistem.Logar(Jesus, "456");
            
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
