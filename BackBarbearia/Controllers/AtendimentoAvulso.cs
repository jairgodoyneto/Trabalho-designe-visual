using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;
namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]
public class AtendimentoAvulsoController : ControllerBase
{
    private SalaoDbContext? _context;

    public AtendimentoAvulsoController(SalaoDbContext context)
    {
        _context = context;
    }

    [HttpGet()]
    [Route("Listar Atendimento Avulso")]
    public async Task<ActionResult<IEnumerable<AtendimentoAvulso>>> Listar()
    {
        if (_context is null) return NotFound();
        if (_context.AtendimentoAvulso is null)return NotFound();
        return await _context.AtendimentoAvulso.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar Atendimento Avulso/{id}")]
    public async Task<ActionResult<AtendimentoAvulso>> Buscar([FromRoute] int id)
    {
        if (_context is null) return NotFound();
        if (_context.AtendimentoAvulso is null) return NotFound();
        AtendimentoAvulso? AtendimentoAvulso = await _context.AtendimentoAvulso.FindAsync(id);
        if (AtendimentoAvulso is null)
            return NotFound();
        return AtendimentoAvulso;
    }
    [HttpPost()]
    [Route("Novo Atendimento Avulso/")]
    public async Task<IActionResult> Cadastrar(AtendimentoAvulso atendimento)
    {
        _context?.Add(atendimento);
        _context?.SaveChanges();
        return Created("",atendimento);
    }
    [HttpPatch()]
    [Route("alterar Atendimento Avulso ")]
    public async Task<ActionResult> Alterar(AtendimentoAvulso AtendimentoAvulso)
    {
        if (_context is null) return NotFound();
        if (_context.AtendimentoAvulso is null) return NotFound();
        var AtendimentoAvulsoTemp = await _context.AtendimentoAvulso.FindAsync(AtendimentoAvulso.Id);
        if(AtendimentoAvulsoTemp is null) return NotFound();
        _context.AtendimentoAvulso.Update(AtendimentoAvulso);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete()]
    [Route("excluir Atendimento Avulso/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if (_context is null) return NotFound();
        if (_context.AtendimentoAvulso is null) return NotFound();
        var AtendimentoAvulsoTemp = await _context.AtendimentoAvulso.FindAsync(id);
        if(AtendimentoAvulsoTemp is null) return NotFound();
        _context.Remove(AtendimentoAvulsoTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}