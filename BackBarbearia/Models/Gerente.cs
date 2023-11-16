using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    [Table("Gerente")]
    public class Gerente : Pessoa
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int GerenteId{get;set;}
    }
}