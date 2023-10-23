using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salao.Models
{
    [Table("Cliente")]
    public class Cliente : Pessoa
    {
        public int _clienteId;
        public Cliente(): base()
        {
        }
        public Cliente(string cpf, string nome, string email) : base(nome, cpf, email)
        {
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