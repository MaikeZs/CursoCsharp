using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorInvestido = 0;
            double Rendimentodovalor = 1.06;


            for (int contadorAno = 1; contadorAno <= 20; contadorAno++) 
           {

                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    ValorInvestido*=Rendimentodovalor;
                    ValorInvestido += 9000;

                   
                }
                ValorInvestido -= ValorInvestido * 0.27;
                Console.WriteLine($"Ao término do ano {contadorAno} , você terá R$" + ValorInvestido);
            }







            Console.ReadLine();
        }
    }
}
