using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Models;
namespace Salao.Data;
public class SalaoDbContext : DbContext
{
    public DbSet<Cliente>? Cliente{ get;set;}
    public DbSet<Barbeiro>? Barbeiro{get;set;}
    public DbSet<AtendimentoAgendado>? AtendimentoAgendado{get;set;}
    public DbSet<Servico>? Servico{get;set;}
    public DbSet<UnidadeAtendimento>? UnidadeAtendimento{get;set;}
    public DbSet<AtendimentoAvulso>? AtendimentoAvulso{get;set;}
    public DbSet<Agenda>? Agenda{get;set;}
    public DbSet<HorarioLivre>? HorarioLivre{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=salao.db;Cache=shared");

    }
}

