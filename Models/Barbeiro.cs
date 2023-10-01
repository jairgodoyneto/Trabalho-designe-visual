using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    [Table("Barbeiro")]
    public class Barbeiro : Pessoa
    {
        private int _barbeiroId;
        private string _senha;

        public Barbeiro() : base()
        {
            _senha = String.Empty;
        }
         public Barbeiro(string senha, string cpf, string nome, string email) : base(nome, cpf, email)
        {
            _senha = senha;
        }
        public string Senha
        {
            get => _senha;
            set => _senha=value;
        }
        [Key]
        public int BarbeiroId
        {
            get=>_barbeiroId;
            set=>_barbeiroId=value;
        }
    }
}