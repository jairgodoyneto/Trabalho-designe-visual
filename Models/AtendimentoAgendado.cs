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
        public AtendimentoAgendado(Barbeiro barbeiro, Servico servico, DateTime data, Cliente cliente): base(barbeiro,servico,data)
        {
            _cliente=cliente;
        }
        
        public int ClienteId{get;set;}
        [ForeignKey("ClienteId")]
        public  Cliente Cliente{get=> _cliente;set=> _cliente=value;}
    }
}