
namespace Salao.Models
{
    public class Atendimento
    {
        private Barbeiro _barbeiro;

        private Cliente _cliente;

        private Servico _servico;

        private DateTime _data;

        public Atendimento()
        {
            _barbeiro = new Barbeiro();
            _cliente = new Cliente();
            _servico = new Servico();
            _data = new DateTime();
        }
        public Barbeiro Barbeiro;
        public Cliente Cliente;
        public Servico Servico;
        public DateTime Data;
    }
}