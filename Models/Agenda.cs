using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
            _id=0;
            _barbeiro = new Barbeiro();
            _atendimentos = new List<Atendimento>();
            _horariosLivres = new List<DateTime>();
            _unidadeAtendimento = new UnidadeAtendimento();
        }
        public Agenda(int id,Barbeiro barbeiro, List<Atendimento> atendimentos, List<DateTime> horariosLivres, UnidadeAtendimento unidadeAtendimento)
        {
            _id=id;
            _barbeiro= barbeiro;
            _atendimentos=atendimentos;
            _horariosLivres=horariosLivres;
            _unidadeAtendimento=unidadeAtendimento;
        }
        [Key]
        public int AgendaId
        {
            get=>_id;
            set=>_id=value;
        }
        [ForeignKey("BarbeiroId")]
        public int BarbeiroId{get;set;}
        public virtual Barbeiro Barbeiro{get=>_barbeiro;set=>_barbeiro=value;}
        [ForeignKey("AtendimentoId")]
        public  List<Atendimento> Atendimentos{get=> _atendimentos;set=> _atendimentos=value;}
    }
}