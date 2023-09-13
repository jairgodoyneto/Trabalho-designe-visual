using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class UnidadeAtendimento
    {
        private string _endereco;
        private int _cep;
        private List<Pessoa> _funcionarios;

        public UnidadeAtendimento()
        {
            _endereco= String.Empty;
            _cep=0;
            _funcionarios=new();
        }
    }
}