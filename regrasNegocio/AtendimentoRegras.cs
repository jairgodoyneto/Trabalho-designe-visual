
using Microsoft.EntityFrameworkCore.InMemory.Query.Internal;
using Salao.Models;

public static class AtendimentoRegras
{
    public static int ano = 2023;
    public static Atendimento definirHoras(int mes,int dia,int hora, int min)
    {
        var data = new DateTime(ano,mes,dia,hora,min,0);
        var data2= DateTime.Today;
        int x= DateTime.Compare(data,data);
        if(x<0)
        {
        }
        return null;
    }
}