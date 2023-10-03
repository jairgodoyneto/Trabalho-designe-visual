using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Controllers;
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
    [Route("Novo_Atendimento")]
    public IActionResult Cadastrar(AtendimentoAgendado atendimento)
    {
        /*
        AtendimentoAgendado atendimento= new();
        if(_context is null) return NotFound();
        if(_context.Barbeiro is null) return NotFound("Barbeiro1");
        Barbeiro? barbeiro = _context.Barbeiro.Find(barbeiroId);
        if (barbeiro is null) return NotFound("Barbeiro2");
        atendimento.Barbeiro=barbeiro;

        if(_context.Cliente is null) return NotFound("Cliente1");
        Cliente? cliente = await _context.Cliente.FindAsync(clienteId);;
        if (cliente is null) return NotFound("Cliente2");
        atendimento.Cliente=cliente;

        if(_context.Servico is null) return NotFound("Servico2");
        Servico servicoTemp;
        if((servicoTemp= await _context.Servico.FindAsync(servicoId)) is null) return NotFound("Servico2");
        atendimento.Servico=servicoTemp;
        */
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
    [Route("Excluir/{id}")]
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
}