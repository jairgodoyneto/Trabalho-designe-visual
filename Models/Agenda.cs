using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Agenda
    {
        private Barbeiro _barbeiro;
        private List<Atendimento> _atendimentos;
        private List<DateTime> _HorariosLivres;
        private UnidadeAtendimento _unidadeAtendimento;
        public Agenda()
        {
            _barbeiro = new Barbeiro();
            _atendimentos = new List<Atendimento>();
            _HorariosLivres = new List<DateTime>();
            _unidadeAtendimento = new UnidadeAtendimento();
        }
    }
}