using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models
{
    public class Gerente : Pessoa
    {
        private int _gerenteId;
        private string _senha;
        
        public Gerente():base()
        {
            _senha = String.Empty;
        }
        public String Senha
        {
            get=>_senha;
            set=>_senha=value; 
       }
       [Key]
       public int GerenteId{get=>_gerenteId;set=>_gerenteId=value;}
    }
}