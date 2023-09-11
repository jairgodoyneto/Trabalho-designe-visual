using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Gerente : Pessoa
    {
        private string _senha;
        
        public Gerente():base()
        {
            _senha = String.Empty;
        }
    }
}