
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Salao.Models
{
    public abstract class Atendimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public int BarbeiroId{get;set;}
        public  Barbeiro? Barbeiro{get ;set;}
        public int ServicoId{get;set;}
        public Servico? Servico{get;set;}

        public int ClienteId{get;set;}
        public  Cliente? Cliente{get;set;}
    }
}