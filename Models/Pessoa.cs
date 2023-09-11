using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public abstract class Pessoa
    {
        private int id;
        private string nome;
        private string cpf;

        public Pessoa()
        {
            nome = String.Empty;
            cpf = String.Empty;
        }
        public Pessoa(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
        public int Id
        {
            get =>  id;
            set => id = value; 
        }
        public string Nome
        {
            get => nome;
            set => nome = value; 
        }
        public string Cpf
        {
            get => cpf; 
            set => cpf = value; 
        }
    }
}