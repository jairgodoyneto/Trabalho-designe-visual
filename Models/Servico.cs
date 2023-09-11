using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Servico
    {
        private string nome;
        private string descricao;
        private float custo;
        private int duracao;

        public Servico()
        {
            nome= String.Empty;
            descricao= String.Empty;
            custo = 0;
            duracao = 0;
        }
        public string Nome
        {
            get => nome; 
            set => nome = value; 
        }
        public string Descricao 
        {
            get => descricao;
            set => descricao = value;
        }
        public float Custo
        {
            get => custo;
            set => custo = value;
        }
    }
}