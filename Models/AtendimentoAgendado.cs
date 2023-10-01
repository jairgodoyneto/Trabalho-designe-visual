using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salao.Models
{
    [Table("AtendimentoAgendado")]
    public class AtendimentoAgendado : Atendimento
    {
        private Cliente _cliente;

        public AtendimentoAgendado(): base()
        {
            _cliente = new Cliente();
        }
        [ForeignKey("ClienteId")]
        public int ClienteId{get;set;}
        public virtual Cliente Cliente{get=> _cliente;set=> _cliente=value;}
    }
}