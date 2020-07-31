using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {

            int mes = 12;

            switch (mes) 
            {
                case 1:
                    Console.WriteLine("Mes De Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Mes de Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Mes de Marco");
                    break;
                case 4:
                    Console.WriteLine("Mes de Abril");
                    break;
                case 5:
                    Console.WriteLine("Mes de Maio");
                    break;
                case 6:
                    Console.WriteLine("Mes de Junho");
                    break;
                case 7:
                    Console.WriteLine("Mes de Julho");
                    break;
                case 8:
                    Console.WriteLine("Mes de Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes de Setembro");
                    break;
                case 10:
                    Console.WriteLine("Mes de Outumbro");
                    break;
                case 11:
                    Console.WriteLine("Mes de Novembro");
                    break;
                case 12:
                    Console.WriteLine("Mes de Dezembro");
                    Console.WriteLine("Fim de Ano!!");
                    break;
                default:
                    Console.WriteLine("Mes Invalido");
                    break;
            }


            Console.ReadLine();
        }

    }
}
