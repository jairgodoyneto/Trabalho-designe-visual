using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Gerente : Pessoa
    {
        private string senha;
        
        public Gerente():base()
        {
            senha = String.Empty;
        }
    }
}