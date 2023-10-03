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
    [Route("Novo_Atendimento")]
    public async Task<IActionResult> CadastrarAsync(AtendimentoAgendado atendimento)
    {
        //if(_context is null) return NotFound();
        //if(_context.Barbeiro is null) return NotFound();
        //var barbeiroTemp= await _context.Barbeiro.FindAsync(atendimento.Barbeiro.BarbeiroId);
        //if (barbeiroTemp is null) return NotFound();
        //atendimento.Barbeiro=barbeiroTemp;

        //if(_context.Cliente is null) return NotFound();
        //var clienteTemp= await _context.Cliente.FindAsync(atendimento.Cliente.ClienteId);
        //if (clienteTemp is null) return NotFound();
        //atendimento.Cliente=clienteTemp;

        //if(_context.Servico is null) return NotFound();
       // var servicoTemp= await _context.Servico.FindAsync(atendimento.Servico.ServicoId);
        //if(servicoTemp is null) return NotFound();
       // atendimento.Servico=servicoTemp;

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