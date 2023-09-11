using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public abstract class Pessoa
    {
        private int _id;
        private string _nome;
        private string _cpf;

        public Pessoa()
        {
            _id=0;
            _nome = String.Empty;
            _cpf = String.Empty;
        }
        public Pessoa(int id,string nome, string cpf)
        {
            _id = id;
            _nome = nome;
            _cpf = cpf;
        }
        public int Id
        {
            get =>  _id;
            set => _id = value; 
        }
        public string Nome
        {
            get => _nome;
            set => _nome = value; 
        }
        public string Cpf
        {
            get => _cpf; 
            set => _cpf = value; 
        }
    }
}