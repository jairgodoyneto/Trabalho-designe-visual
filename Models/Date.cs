
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salao.Models;

public class Date
{
    public int _id;
    public int _dia;
    public DateTime _tempo;
    public Date()
    {
        _dia=DateTime.DaysInMonth(2023,10);
        _tempo=DateTime.Today;
    }
    public Date(int dia,DateTime _tempo)
    {
        _dia=dia;
        _tempo=DateTime.Today;
    }
    [Key]
    public int DateId{get=>_id;set=>_id=value;}
    public int Dia{get=>_id;set=>_id=value;}
    public DateTime Tempo{get=>_tempo;set=>_tempo=value;}
}