
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Salao.Models
{
    public abstract class Atendimento
    {
        private Barbeiro _barbeiro;

        private Servico _servico;

        private DateTime _data;
        /*
        public Atendimento()
        {
            _barbeiro = new Barbeiro();
            _servico = new Servico();
            _data = DateTime.Now;
        }
        public Atendimento(Barbeiro barbeiro, Servico servico, DateTime data)
        {
            _barbeiro = barbeiro;
            _servico = servico;
            _data= data;
        }*/

        public int BarbeiroId{get;set;}
        [ForeignKey("BarbeiroId")]
        public  Barbeiro Barbeiro{get => _barbeiro;set =>_barbeiro =value;}
        public int ServicoId{get;set;}
        [ForeignKey("ServicoId")]
        public Servico Servico{get=>_servico;set=>_servico=value;}

        [Key]
        public int AtendimentoId {get;set;}
       
        public DateTime Data{get => _data;set =>_data =value;}
    }
}