
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salao.Models
{
    public class Agenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get;set;}
        public int BarbeiroId{get;set;}
        public Barbeiro? Barbeiro{get;set;}
        public List<AtendimentoAgendado>? Atendimentos{get;set;}
        public List<HorarioLivre>? Horarios{get;set;}
    }
}