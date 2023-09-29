using System.ComponentModel.DataAnnotations;

namespace Salao.Models
{
    public class AtendimentoAgendado : Atendimento
    {
        private Cliente _cliente;

        public AtendimentoAgendado(): base()
        {
            _cliente = new Cliente();
        }
        public Cliente Cliente{get=> _cliente;set=> _cliente=value;}
    }
}