using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;
namespace Salao.Controllers;
[ApiController]
[Route("[controller]")]
public class AtendimentoController : ControllerBase
{
    private SalaoDbContext? _context;
    public AtendimentoController(SalaoDbContext context)
    {
        _context = context;
    }
    [HttpPost()]
    [Route("Novo Atendimento/")]
    public IActionResult Cadastrar(AtendimentoAgendado atendimento)
    {
        _context.Add(atendimento);
        _context.SaveChanges();
        return Created("",atendimento);
    }
    [HttpGet()]
    [Route("Listar atendimentos")]
    public async Task<ActionResult<IEnumerable<AtendimentoAgendado>>> ListarAtendimentos()
    {
        if (_context.AtendimentoAgendado is null)return NotFound();
        return await _context.AtendimentoAgendado.ToListAsync();
    }
    [HttpDelete()]
    [Route("Excluir atendimento/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if(_context is null) return NotFound();
        if(_context.AtendimentoAgendado is null) return NotFound();
        var atendimentoTemp = await _context.AtendimentoAgendado.FindAsync(id);
        if(atendimentoTemp is null) return NotFound();
        _context.Remove(atendimentoTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpGet()]
    [Route("buscar Atendimento/{id}")]
    public async Task<ActionResult<AtendimentoAgendado>> Buscar([FromRoute] int id)
    {
        if (_context.Barbeiro is null)return NotFound();
        AtendimentoAgendado atendimento = await _context.AtendimentoAgendado.FindAsync(id);
        if (atendimento is null)return NotFound();
        return atendimento;
    }
}