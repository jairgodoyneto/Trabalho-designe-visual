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

        public Pessoa()
        {
            _nome = String.Empty;
            _cpf = String.Empty;
        }
        public Pessoa(string nome, string cpf)
        {
            _nome = nome;
            _cpf = cpf;
        }
        [Key]
        public int Id{get;set;}
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