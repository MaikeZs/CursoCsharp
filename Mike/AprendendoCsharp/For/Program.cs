using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes ++) 
            {
                valorInvestido *=  1.0036;
                Console.WriteLine(
                "Após " + contadorMes +
                " meses, você terá R$" + valorInvestido);
            }







            Console.ReadLine();
        }
    }
}
