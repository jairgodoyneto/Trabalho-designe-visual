using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    [Table("Servico")]
    public class Servico
    {
        private int _id;
        private string _nome;
        private string _descricao;
        private float _custo;
        private int _duracao;

        public Servico()
        {
            _nome= String.Empty;
            _descricao= String.Empty;
            _custo = 0;
            _duracao = 0;
        }
        [Key]
        public int ServicoId
        {
            get=> _id;
            set=> _id=value;
        }
        public string Nome
        {
            get => _nome; 
            set => _nome = value; 
        }
        public string Descricao 
        {
            get => _descricao;
            set => _descricao = value;
        }
        public float Custo
        {
            get => _custo;
            set => _custo = value;
        }
        public int Duracao
        {
            get=>_duracao;
            set=>_duracao=value;
        }
    }
}