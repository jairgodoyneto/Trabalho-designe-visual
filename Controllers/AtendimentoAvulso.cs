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
    [Route("Listar AtendimentoAvulso")]
    public async Task<ActionResult<IEnumerable<AtendimentoAvulso>>> Listar()
    {
        if (_context is null) return NotFound();
        if (_context.AtendimentoAvulso is null)return NotFound();
        return await _context.AtendimentoAvulso.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar AtendimentoAvulso/{id}")]
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
    [Route("Novo_Atendimento_avulso/{ClienteId}/{BarbeiroId}/{ServicoId}")]
    public async Task<IActionResult> Cadastrar([FromRoute] int ClienteId,[FromRoute] int BarbeiroId,[FromRoute] int ServicoId)
    {
        if(_context is null) return NotFound();
        if(_context.Barbeiro is null) return NotFound();
        var barbeiroTemp= await _context.Barbeiro.FindAsync(BarbeiroId);
        if (barbeiroTemp is null) return NotFound();
        AtendimentoAvulso atendimento = new();
        atendimento.Barbeiro=barbeiroTemp;

        if(_context.Cliente is null) return NotFound();
        var clienteTemp= await _context.Cliente.FindAsync(ClienteId);
        if (clienteTemp is null) return NotFound();
        atendimento.Cliente=clienteTemp;

        if(_context.Servico is null) return NotFound();
        var servicoTemp= await _context.Servico.FindAsync(ServicoId);
        if(servicoTemp is null) return NotFound();
        atendimento.Servico=servicoTemp;

        _context.Add(atendimento);
        _context.SaveChanges();
        return Created("",atendimento);
    }
    [HttpPut()]
    [Route("alterar Atendimento Avulso ")]
    public async Task<ActionResult> Alterar(AtendimentoAvulso AtendimentoAvulso)
    {
        if (_context is null) return NotFound();
        if (_context.AtendimentoAvulso is null) return NotFound();
        var AtendimentoAvulsoTemp = await _context.AtendimentoAvulso.FindAsync(AtendimentoAvulso.AtendimentoId);
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