using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Cliente : Pessoa
    {
        private string _senha;
        public Cliente(): base()
        {
            _senha = String.Empty;
        }
        public Cliente(string senha, string cpf, string nome) : base(nome, cpf)
        {
            _senha = senha;
        }
        public string Senha
        {
            get =>  _senha; 
            set => _senha = value;
        }
         
    }
}