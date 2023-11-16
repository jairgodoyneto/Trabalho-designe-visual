using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Salao.Models
{
    public class Agenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get;set;}
        public int BarbeiroId{get;set;}
        public Barbeiro? Barbeiro{get;set;}
        public int UnidadeId{get;set;}
        public UnidadeAtendimento? Unidade{get;set;}
        public List<Atendimento>? Atendimentos{get;set;}
        //public List<DateTime> HorariosLivres{get=>_horariosLivres;set=>_horariosLivres=value;}
    }
}