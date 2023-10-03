
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
        }
        [ForeignKey("BarbeiroId")]
        public int BarbeiroId{get;set;}
        public  Barbeiro Barbeiro{get => _barbeiro;set =>_barbeiro =value;}
        [ForeignKey("ServicoId")]
        public int ServicoId{get;set;}
        public Servico Servico{get=>_servico;set=>_servico=value;}
        public DateTime Data{get => _data;set =>_data =value;}
    }
}