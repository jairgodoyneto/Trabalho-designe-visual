using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Salao.Models;

[Table("UnidadeAtendimento")]
public class UnidadeAtendimento
{
    private int _id;
    private string _endereco;
    private int _cep;
    private List<Pessoa> _funcionarios;

    public UnidadeAtendimento()
    {
        _endereco= String.Empty;
        _cep=0;
        _funcionarios=new();
    }
    public int Id{get=>_id;set=>_id=value;}
    public string Endereco{get=>_endereco;set=>_endereco=value;}
    [OneToMany(typeof(Pessoa))]
    public List<Pessoa> Funcionarios{get=>_funcionarios;set=>Funcionarios=value;} 
}
[AttributeUsage(AttributeTargets.Property)]
public class OneToManyAttribute : Attribute
{
    public Type RelatedType { get;}

    public OneToManyAttribute(Type relatedType)
    {
            RelatedType = relatedType;
    }
}    

