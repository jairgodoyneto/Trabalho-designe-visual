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
    [Route("Novo_Atendimento/{ClienteId}/{BarbeiroId}/{ServicoId}")]
    public async Task<IActionResult> Cadastrar([FromRoute] int ClienteId,[FromRoute] int BarbeiroId,[FromRoute] int ServicoId, int mes,int dia, int hora, int minutos)
    {
        if(_context is null) return NotFound();
        if(_context.Barbeiro is null) return NotFound();
        var barbeiroTemp= await _context.Barbeiro.FindAsync(BarbeiroId);
        if (barbeiroTemp is null) return NotFound();
        AtendimentoAgendado atendimento = new();
        atendimento.Barbeiro=barbeiroTemp;

        if(_context.Cliente is null) return NotFound();
        var clienteTemp= await _context.Cliente.FindAsync(ClienteId);
        if (clienteTemp is null) return NotFound();
        atendimento.Cliente=clienteTemp;

        if(_context.Servico is null) return NotFound();
        var servicoTemp= await _context.Servico.FindAsync(ServicoId);
        if(servicoTemp is null) return NotFound();
        atendimento.Servico=servicoTemp;

        atendimento.Horario=new DateTime(2023,mes,dia,hora,minutos,0);

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