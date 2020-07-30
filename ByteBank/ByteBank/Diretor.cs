using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
  public class Diretor:Funcionario
    {
        public override void AumentoDeSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario *= 1.20;
        }
    }
}
