
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
        [Key]
        public int Id {get;set;}
        [ForeignKey("Barbeiro")]
        public int BarbeiroId{get;set;}
        public virtual Barbeiro Barbeiro{get => _barbeiro;set =>_barbeiro =value;}
        public Servico Servico{get => _servico;set =>_servico =value;}
        public DateTime Data{get => _data;set =>_data =value;}
    }
}