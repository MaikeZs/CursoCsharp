﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class JovermAprendiz : Funcionario
    {
        public JovermAprendiz(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentoDeSalario()
        {
            Salario *= 1.09;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.06;
        }
    }
}
