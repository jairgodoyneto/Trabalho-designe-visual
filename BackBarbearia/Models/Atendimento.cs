
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salao.Models
{
    public abstract class Atendimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public int ServicoId{get;set;}
        public Servico? Servico{get;set;}
        public int ClienteId{get;set;}
        public  Cliente? Cliente{get;set;}
    }
}