using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Barbeiro : Pessoa
    {
        private string _senha;

        public Barbeiro() : base()
        {
            _senha = String.Empty;
        }
        public string Senha
        {
            get => _senha;
            set => _senha=value;
        }
    }
}