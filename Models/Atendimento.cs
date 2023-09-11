
namespace Salao.Models
{
    public class Atendimento
    {
        private Barbeiro barbeiro;

        private Cliente cliente;

        private Servico servico;

        private DateTime data;

        public Atendimento()
        {
            barbeiro = new Barbeiro();
            cliente = new Cliente();
            servico = new Servico();
            data = new DateTime();
        }
        public Barbeiro Barbeiro;
        public Cliente Cliente;
        public Servico Servico;
        public DateTime Data;
    }
}