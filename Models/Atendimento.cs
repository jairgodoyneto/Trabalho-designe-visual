
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
        public Barbeiro Barbeiro{get => _barbeiro;set =>_barbeiro =value;}
        public Servico Servico{get => _servico;set =>_servico =value;}
        public DateTime Data{get => _data;set =>_data =value;}
    }
}