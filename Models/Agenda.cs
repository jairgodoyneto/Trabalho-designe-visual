using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Agenda
    {
        private Barbeiro barbeiro;
        private List<Atendimento> atendimentos;
        private List<DateTime> HorariosLivres;

        public Agenda()
        {
            barbeiro = new Barbeiro();
            atendimentos = new List<Atendimento>();
            HorariosLivres = new List<DateTime>();
        }
    }
}