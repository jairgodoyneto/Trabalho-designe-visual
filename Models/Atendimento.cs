
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Salao.Models
{
    public abstract class Atendimento
    {
        private Cliente _cliente;
        public Barbeiro _barbeiro;

        public Servico _servico;

        
        public Atendimento()
        {
            _barbeiro = new Barbeiro();
            _servico = new Servico();
            _cliente = new Cliente();
        }
        public Atendimento(Barbeiro barbeiro, Servico servico, Cliente cliente)
        {
            _barbeiro = barbeiro;
            _servico = servico;
            _cliente = cliente;
        }

        public int BarbeiroId{get;set;}
        [ForeignKey("BarbeiroId")]
        public  Barbeiro Barbeiro{get => _barbeiro;set =>_barbeiro =value;}
        public int ServicoId{get;set;}
        [ForeignKey("ServicoId")]
        public Servico Servico{get=>_servico;set=>_servico=value;}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AtendimentoId {get;set;}
        public int ClienteId{get;set;}
        [ForeignKey("ClienteId")]
        public  Cliente Cliente{get=> _cliente;set=> _cliente=value;}
    }
}