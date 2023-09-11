using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Cliente : Pessoa
    {
        private string senha;
        public Cliente(): base()
        {
            senha = String.Empty;
        }
        public Cliente(string senha, string cpf, string nome) : base(nome, cpf)
        {
            this.senha = senha;
        }
        public string Senha
        {
            get =>  senha; 
            set => senha = value;
        }
         
    }
}