using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
   public class Gerente:Funcionario
    {
        public override void AumentoDeSalario()
        {
            Salario *= 1.13;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

    }
}
