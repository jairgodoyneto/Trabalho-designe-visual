using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salao.Models
{
    [Table("AtendimentoAgendado")]
    public class AtendimentoAgendado : Atendimento
    {
        private Cliente _cliente;
        private DateTime _horario;
        public int ClienteId{get;set;}

        [ForeignKey("ClienteId")]
        public  Cliente Cliente{get=> _cliente;set=> _cliente=value;}
        public DateTime Horario{get=> _horario;set=> _horario=value;}
    }
}