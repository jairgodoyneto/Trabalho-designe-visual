using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salao.Models
{
    [Table("Cliente")]
    public class Cliente : Pessoa
    {
        public int _clienteId;
        private string _senha;
        public Cliente(): base()
        {
            _senha = String.Empty;
        }
        public Cliente(string senha, string cpf, string nome, string email) : base(nome, cpf, email)
        {
            _senha = senha;
        }
        public string Senha
        {
            get =>  _senha; 
            set => _senha = value;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId
        {
            get=>_clienteId;
            set=>_clienteId=value;
        }
    }
}