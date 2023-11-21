using System.ComponentModel.DataAnnotations;
public class HorarioLivre
{
    [Key]
    public int Id{get;set;}
    public DateTime Horario{get;set;}

}