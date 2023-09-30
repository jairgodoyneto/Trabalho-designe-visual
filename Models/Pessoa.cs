using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Salao.Models
{
    public abstract class Pessoa
    {
        
        private string _nome;
        private string _cpf;
        private string _email;
        public Pessoa()
        {
            _nome = String.Empty;
            _cpf = String.Empty;
            _email=string.Empty;
        }
        public Pessoa(string nome, string cpf,string email)
        {
            _nome = nome;
            _cpf = cpf;
            _email=email;
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
        public string email
        {
            get=> _email;
            set=> _email=value;
        }
    }
}