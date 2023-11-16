using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;
namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]
public class AgendaController : ControllerBase
{
    private SalaoDbContext? _context;

    public AgendaController(SalaoDbContext context)
    {
        _context = context;
    }

    [HttpGet()]
    [Route("Listar Agenda")]
    public async Task<ActionResult<IEnumerable<Agenda>>> Listar()
    {
        if (_context is null) return NotFound();
        if (_context.Agenda is null)return NotFound();
        return await _context.Agenda.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar Agenda/{id}")]
    public async Task<ActionResult<Agenda>> Buscar([FromRoute] int id)
    {
        if (_context is null) return NotFound();
        if (_context.Agenda is null) return NotFound();
        Agenda? Agenda = await _context.Agenda.FindAsync(id);
        if (Agenda is null)
            return NotFound();
        return Agenda;
    }
    [HttpPost()]
    [Route("inserirAgenda/{barbeiroId}/{unidadeId}")]
    public async  Task<IActionResult> Cadastrar([FromRoute]int barbeiroId,[FromRoute]int unidadeId)
    {
        if (_context ==null){return NotFound("Base vazia");}
        if (_context.Barbeiro == null){return NotFound("Base barbeiro vazia");}
        if (_context.UnidadeAtendimento == null){return NotFound("Base unidade vazia");}

        var barbeiro = await _context.Barbeiro.FindAsync(barbeiroId);
        if(barbeiro == null){return NotFound("nao achou barbeiro");}
        var unidadeAtendimento = await _context.UnidadeAtendimento.FindAsync(unidadeId);
        if(unidadeAtendimento == null){return NotFound("Nao achou unidade");}
        Agenda agenda= new();
        agenda.Barbeiro=barbeiro;
        agenda.Unidade=unidadeAtendimento;
        _context.Add(agenda);
        _context.SaveChanges();
        return Created("",agenda);
    }
    [HttpPut()]
    [Route("alterar Agenda ")]
    public async Task<ActionResult> Alterar(Agenda Agenda)
    {
        if (_context is null) return NotFound();
        if (_context.Agenda is null) return NotFound();
        var AgendaTemp = await _context.Agenda.FindAsync(Agenda.Id);
        if(AgendaTemp is null) return NotFound();
        _context.Agenda.Update(Agenda);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete()]
    [Route("excluir Agenda/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Agenda is null) return NotFound();
        var AgendaTemp = await _context.Agenda.FindAsync(id);
        if(AgendaTemp is null) return NotFound();
        _context.Remove(AgendaTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}