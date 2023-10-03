using System.ComponentModel.DataAnnotations.Schema;
namespace Salao.Models
{
    [Table("AtendimentoAvulso")]
    public class AtendimentoAvulso : Atendimento
    {
        public AtendimentoAvulso(Barbeiro barbeiro, Servico servico, DateTime data): base(barbeiro,servico,data)
        {
        }
    }
}