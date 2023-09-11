using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Barbeiro : Pessoa
    {
        private string senha;

        public Barbeiro() : base()
        {
            senha = String.Empty;
        }
    }
}