using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]
public class ServicoController : ControllerBase
{
    private SalaoDbContext? _context;
    public ServicoController(SalaoDbContext context)
    {
        _context = context;
    }

    [HttpPost()]
    [Route("inserir Servico")]
    public IActionResult Cadastrar(Servico servico)
    {
        _context.Add(servico);
        _context.SaveChanges();
        return Created("",servico);
    }
    [HttpPut()]
    [Route("alterar servico")]
    public async Task<ActionResult> Alterar(Servico servico)
    {
        if (_context is null) return NotFound();
        if (_context.Servico is null) return NotFound();
        var servicoTemp = await _context.Servico.FindAsync(servico.Id);
        if(servicoTemp is null) return NotFound();
        _context.Servico.Update(servicoTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete()]
    [Route("excluir servico/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Servico is null) return NotFound();
        var servicoTemp = await _context.Servico.FindAsync(id);
        if(servicoTemp is null) return NotFound();
        _context.Remove(servicoTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpGet()]
    [Route("Listar servicos")]
    public async Task<ActionResult<IEnumerable<Servico>>> ListarServico()
    {
        if (_context is null) return NotFound();
        if (_context.Servico is null)
            return NotFound();
        return await _context.Servico.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar Servico/{id}")]
    public async Task<ActionResult<Servico>> Buscar([FromRoute] int id)
    {
        if (_context.Servico is null)return NotFound();
        Servico? servico = await _context.Servico.FindAsync(id);
        if (servico is null)return NotFound();
        return servico;
    }
}