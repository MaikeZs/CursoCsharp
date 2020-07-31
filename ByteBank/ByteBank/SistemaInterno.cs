﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
  public  class SistemaInterno 
    {
        public bool Logar (IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
                if(usuarioAutenticado)
            {
                Console.WriteLine("Seja Bem-Vindo Ao Banco ByteBank");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta !!!");
                return false;
            }
        }
    }
}
