using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salao.Models
{
    [Table("AtendimentoAgendado")]
    public class AtendimentoAgendado : Atendimento
    {
        private DateTime _horario;
        public DateTime Horario{get=> _horario;set=> _horario=value;}
    }
}