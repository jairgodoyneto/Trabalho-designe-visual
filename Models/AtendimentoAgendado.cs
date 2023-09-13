namespace Salao.Models
{
    class AtendimentoAgendado : Atendimento
    {
        private Cliente _cliente;

        public AtendimentoAgendado(): base()
        {
            _cliente = new Cliente();
        }
    }
}