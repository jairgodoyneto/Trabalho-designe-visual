using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Models;
namespace Salao.Data;
public class SalaoDbContext : DbContext
{
    public DbSet<Cliente>? Cliente{ get;set;}
    public DbSet<Cliente>? Barbeiro{ get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=salao.db;Cache=shared");
    }
}

