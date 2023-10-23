
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salao.Models
{
    [Table("Barbeiro")]
    public class Barbeiro : Pessoa
    {
        private int _barbeiroId;

        public Barbeiro() : base()
        {
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarbeiroId
        {
            get=>_barbeiroId;
            set=>_barbeiroId=value;
        }
    }
}