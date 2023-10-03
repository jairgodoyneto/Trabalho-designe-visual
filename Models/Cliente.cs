using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salao.Models
{
    [Table("Cliente")]
    public class Cliente : Pessoa
    {
        private int _clienteId;
        private string _senha;
        public Cliente(): base()
        {
            _senha = String.Empty;
        }
        public Cliente(string senha, string cpf, string nome, string email) : base(nome, cpf, email)
        {
            _senha = senha;
        }
        [Key]
        public int ClienteId
        {
            get=>_clienteId;
            set=>_clienteId=value;
        }
        public string Senha
        {
            get =>  _senha; 
            set => _senha = value;
        }
    }
}