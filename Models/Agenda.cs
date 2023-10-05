using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Salao.Models
{
    [Table("Agenda")]
    public class Agenda
    {
        private int _id;
        private Barbeiro _barbeiro;
        private List<Atendimento> _atendimentos;
        private List<DateTime> _horariosLivres;
        private UnidadeAtendimento _unidadeAtendimento;
        public Agenda()
        {
            _barbeiro=new();
            _atendimentos=new();
            _horariosLivres=new();
            _unidadeAtendimento=new();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgendaId
        {
            get=>_id;
            set=>_id=value;
        }
        public int BarbeiroId{get;set;}
        [ForeignKey("BarbeiroId")]
        public Barbeiro Barbeiro{get=>_barbeiro;set=>_barbeiro=value;}
        public int UnidadeId{get;set;}
        [ForeignKey("UnidadeId")]
        public UnidadeAtendimento Unidade{get=>_unidadeAtendimento;set=>_unidadeAtendimento=value;}
        public List<Atendimento> Atendimentos{get=> _atendimentos;set=> _atendimentos=value;}
        //public List<DateTime> HorariosLivres{get=>_horariosLivres;set=>_horariosLivres=value;}
    }
}