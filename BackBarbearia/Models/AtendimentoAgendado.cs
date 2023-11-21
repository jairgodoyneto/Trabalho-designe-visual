using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salao.Models
{
    public class AtendimentoAgendado : Atendimento
    {
        public DateTime? Horario{get;set;}
    }
}