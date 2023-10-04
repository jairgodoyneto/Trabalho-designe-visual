using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
namespace Salao.Models
{
    [Table("UnidadeAtendimento")]
    public class UnidadeAtendimento
    {
        private int _unidadeId;
        private string _endereco;
        private int _cep;
        private List<Barbeiro> _funcionarios;

        public UnidadeAtendimento()
        {
            _endereco = string.Empty;
            _cep = 0;
            _funcionarios = new List<Barbeiro>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnidadeId { get => _unidadeId; set => _unidadeId = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public int Cep { get => _cep; set => _cep = value; }
        public int BarbeiroId{get;set;}
        [ForeignKey("BarbeiroId")]
        public List<Barbeiro> Funcionarios { get => _funcionarios; set => _funcionarios = value; }
    }
}*/